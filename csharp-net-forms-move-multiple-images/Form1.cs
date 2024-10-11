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
            imageNumber++;
            xPos += 55;
            Image newImage = new Image(imageLocation[imageNumber]);
            newImage.position.X = xPos;
            newImage.position.Y = 300;
            newImage.rect.X = newImage.position.X;
            newImage.rect.Y = newImage.position.Y;
            images.Add(newImage);
        }

        private void FormMouseUp(object sender, MouseEventArgs e)
        {
            foreach(Image tempImage in images)
            {
                tempImage.active = false;
            }
            SelectedImage = null;
            lineAnimation = 0;
        }

        private void FormeMouseMove(object sender, MouseEventArgs e)
        {
            if(SelectedImage != null)
            {
                SelectedImage.position.X = e.X - (SelectedImage.width / 2);
                SelectedImage.position.Y = e.Y - (SelectedImage.width / 2);
            }
        }

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            Point mousePosition = new Point(e.X, e.Y);

            foreach(Image newImage in images)
            {
                if(SelectedImage == null)
                {
                    if(newImage.rect.Contains(mousePosition))
                    {
                        SelectedImage = newImage;
                        newImage.active = true;
                        indexValue = images.IndexOf(newImage);
                        label1.Text = "Card " + (indexValue + 1) + " of " + totalImages;
                    }
                }
            }
        }

        private void FormPaint(object sender, PaintEventArgs e)
        {

        }

        private void ImageTimerEvent(object sender, EventArgs e)
        {
            foreach(Image image in images)
            {
                image.rect.X = image.position.X;
                image.rect.Y = image.position.Y;
            }

            if(SelectedImage != null)
            {
                if(lineAnimation < 10)
                {
                    lineAnimation++;
                }
            }
        }
    }
}
