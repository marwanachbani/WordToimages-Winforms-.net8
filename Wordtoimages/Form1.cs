using Spire.Doc;
using Spire.License;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordtoimages
{
    public partial class Form1 : Form
    {
        // Dictionary to store page index and corresponding image paths
        private Dictionary<int, string> pageImagePaths = new Dictionary<int, string>();

        public Form1()
        {
            InitializeComponent();
            SetKey();

            // Initialize panels
            panel2.Visible = false; // Loading panel
            panel3.Visible = false; // Error panel
            panel4.Visible = false; // Conversion success panel
            panel5.Visible = false; // Image preview panel

            // Initialize TreeView
            uiTreeView1.AfterSelect += UiTreeView1_AfterSelect;
        }

        // Event handler for the convert button
        private async void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilePath.Text))
            {
                MessageBox.Show("Please select a Word document.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filePath = txtFilePath.Text;
            string format = GetSelectedFormat();

            if (string.IsNullOrEmpty(format))
            {
                MessageBox.Show("Please select a valid image format (JPG, PNG, or TIFF).", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show loading panel and hide others
            panel3.Visible = false; // Hide error panel
            panel4.Visible = false; // Hide success panel
            panel5.Visible = false; // Hide image preview panel
            panel2.Visible = true;  // Show loading panel

            try
            {
                // Clear previous data
                uiTreeView1.Nodes.Clear();
                pageImagePaths.Clear();
                tree1.Image = null; // Correctly reference the PictureBox

                // Run the conversion on a background thread
                await Task.Run(() => ConvertDocumentToImage(filePath, format));
                panel3.Visible= false;
                // Show success panel
                
            }
            catch (Exception ex)
            {
                // Show error panel with exception message
                panel3.Visible = true;
                panel4.Text = ex.Message;
                
            }
            finally
            {
                // Hide loading panel
                panel2.Visible = false;
                
            }
        }

        // Helper method to get the selected format (JPG, PNG, or TIFF)
        private string GetSelectedFormat()
        {
            if (rdoJPG.Checked) return "jpg";
            if (rdoPNG.Checked) return "png";
            if (rdoTIFF.Checked) return "tiff";
            return null;
        }

        // Method to convert Word document to images using Spire.Doc
        private void ConvertDocumentToImage(string filePath, string format)
        {
            // Load the Word document using Spire.Doc
            Document doc = new Document();
            doc.LoadFromFile(filePath);

            int pageCount = doc.PageCount;

            if (pageCount == 0)
                throw new InvalidOperationException("The document contains no pages.");

            string outputDirectory = Path.Combine(Path.GetDirectoryName(filePath), $"{Path.GetFileNameWithoutExtension(filePath)}_Images");
            Directory.CreateDirectory(outputDirectory);

            // Convert each page to an image and save it
            for (int pageIndex = 0; pageIndex < pageCount; pageIndex++)
            {
                // Convert the page to an image
                Image image = doc.SaveToImages(pageIndex, Spire.Doc.Documents.ImageType.Bitmap);

                // Create the output file name
                string outputFileName = Path.Combine(outputDirectory,
                    $"{Path.GetFileNameWithoutExtension(filePath)}_Page_{pageIndex + 1}.{format}");

                // Save the image in the selected format
                SaveImage(image, outputFileName, format);

                // Store the image path
                pageImagePaths[pageIndex] = outputFileName;

                // Update UI to reflect progress (invoke required because of background thread)
                this.Invoke(new Action(() =>
                {
                    TreeNode node = new TreeNode($"Page {pageIndex + 1}");
                    node.Tag = outputFileName; // Store the path in the Tag property
                    uiTreeView1.Nodes.Add(node);
                }));
                panel3.Visible = false;
            }

            // Optionally, select the first page by default
            if (uiTreeView1.Nodes.Count > 0)
            {
                this.Invoke(new Action(() =>
                {
                    uiTreeView1.SelectedNode = uiTreeView1.Nodes[0];
                }));
            }
        }

        // Method to save the image in the correct format
        private void SaveImage(Image image, string outputFileName, string format)
        {
            switch (format.ToLower())
            {
                case "jpg":
                    image.Save(outputFileName, ImageFormat.Jpeg);
                    break;
                case "png":
                    image.Save(outputFileName, ImageFormat.Png);
                    break;
                case "tiff":
                    image.Save(outputFileName, ImageFormat.Tiff);
                    break;
                default:
                    throw new InvalidOperationException("Unsupported format selected.");
            }
        }

        // Event handler for selecting the file (OpenFileDialog)
        private void radButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Word Documents|*.doc;*.docx";
                openFileDialog.Title = "Select a Word Document";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        // Event handler for TreeView selection
        private void UiTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedImagePath = e.Node.Tag as string;
            if (!string.IsNullOrEmpty(selectedImagePath) && File.Exists(selectedImagePath))
            {
                try
                {
                    // Dispose the previous image to free resources
                    if (tree1.Image != null)
                    {
                        tree1.Image.Dispose();
                        tree1.Image = null;
                    }

                    // Load the selected image
                    tree1.Image = Image.FromFile(selectedImagePath);

                    // Show the image preview panel
                    panel5.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    panel5.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Image file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                panel5.Visible = false;
            }
        }

        // Method to set the license key for Spire.Doc
        private void SetKey()
        {
            string ss = "Idd65VXxKpEAgBvZ1nVhUN+w7vpItcbvurq9YsmKuDda+JAEE9qF2G4YzR3o0s96HLaSfKKXq8fmv/VifgjLP/ZHrAKRewKyimE+b1l5tI82tdsWa+W3TgkLfepngT3Ui+LuaUc8pxXYEPd/bacNeg6yvWi7xVPzxDsE/m3D+OyD1ifz4S4lkOhjUS4pJ9gIKv6eIx0aXzRyczi4c+55+yRRBjUsB3AUS5C4sGq4LaSbeVLRq52visiCeMQxIkO6G38uTOyJl3mplKPrB3tpSTpmDc0j1WLuce1KIA9GbtKqOgh5vJwnXnwR3qeVgEBY2Lgrt6Gu0RModahYN6N5ODyj526SSOsz50jUQsrjfnk2JYKq3D3GA+lshknDJsSyHHkqYNxXfha7GQ4e11FhxALPu81LBXLXez4l73XCV9n6cdvHnyOerI18clWh/g6lgfEG+N+ugko2oxET/WEeIVKoIvpEw9YMv5bQrD6oWlN5GthgiXawtPQ6kM41r0MKW75+6ojDqRbOqvyVwC4HNRf2MXjni/Bdo0KBG3SD119bQfa+4zBREiEz6X26Mv7Tc0n8YzGTcK7VZcRGqI06bp4RDiFvAMrn4Y83gJaVRX6MbSJqwpKXKugSrmf0ck6XzLmhQcjsznnLkToXxvBS2jh6Vy3JZXvt4l8JUF8zE9CPix+kpDcGedXA1MmN/dju6Ps4sgGGAnjrfl1YLHvbQR8kii+h9tKrUrjTT88xvjjwz5IXmC4MX2A6HjSqabQwLVm8wfwNF22Pp1nMuX5DVP2pyNMMYMHIewGlJRSQz3j/7gVbw264aeBJPGyVpxrZCRO7byu/Z8cKTk02S+vZTazhIjV4jmn8zLOsxH0wsbcEpDLw1XnrH4tUiIRDQxRO+EBtpPklyFx9Q8AYkIv91osUiQZ14MXfysJ8oHG8gqHa7uidcd+YgFc3FRlFlVXYqqQlABFg5/ZvUHUklZdiRLenTb2yfl3RffnzA1aevJcLy2sBoWUrTxZlAFu0u8D2+swu0V3juiLM8pO9VDB4gHtQh3n/cnvShuv8hls2fi0TTZvpxLdfBw==";

            string ss2 = $@"
<License Key=""{ss}"" Version=""999.999"">
</License>
";
            File.WriteAllText("license.elic.xml", ss2); // need for Spire.Doc, Name must license.elic.xml

            Spire.License.LicenseProvider.SetLicenseKey(ss);

            Spire.License.LicenseProvider.LoadLicense();
        }
    }
}
