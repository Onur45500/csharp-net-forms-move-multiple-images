namespace csharp_net_forms_move_multiple_images
{
    public partial class Form1 : Form
    {

        List<Image> images = new List<Image>();
        Image SelectedImage;
        int indexValue;
        int xPos = 5;
        List<string> imageLocation = new List<string>();
        int imageNumber = -1;
        int totalImages = 0;
        int lineAnimation = 0;

        public Form1()
        {
            InitializeComponent();
            SetUpApp();
        }

        private void SetUpApp()
        {
            imageLocation = Directory.GetFiles("image", "*.png").ToList();
            totalImages = imageLocation.Count();

            for(int i = 0; i < totalImages; i++)
            {
                MakeImages();
            }

            label1.Text = "Card " + (imageNumber + 1) + " of " + totalImages;
        }

        private void MakeImages()
        {

        }

        private void FormMouseUp(object sender, MouseEventArgs e)
        {

        }

        private void FormeMouseMove(object sender, MouseEventArgs e)
        {

        }

        private void FormMouseDown(object sender, MouseEventArgs e)
        {

        }

        private void FormPaint(object sender, PaintEventArgs e)
        {

        }

        private void ImageTimerEvent(object sender, EventArgs e)
        {

        }
    }
}
