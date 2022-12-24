namespace BlazorSVGDemo.Models;

public class MainViewModel
{
    public MainViewModel()
    {
        Initialize();
    }

    public int ContainerX { get; set; } = 0;
    public int ContainerY { get; set; } = 0;
    public int ElementX { get; set; } = 0;
    public int ElementY { get; set; } = 0;
    public int ContainerMouseX { get; set; } = 0;
    public int ContainerMouseY { get; set; } = 0;
    public bool OverChild { get; set; } = false;
    public int SelectedItem { get; set; } = -1;
    public List<Rectangle> Rectangles { get; set; }

    public void Initialize()
    {
        var rnd = new Random();

        Rectangles = new List<Rectangle>();

        for (var i = 0; i < 10; i++)
        {
            var r = new Rectangle
            {
                RectangleId = i + 1,
                X = rnd.Next(0, 600),
                Y = rnd.Next(0, 600),
                Width = 20 * rnd.Next(5, 10),
                Height = 20 * rnd.Next(5, 10),
                R = rnd.Next(0, 255),
                G = rnd.Next(0, 255),
                B = rnd.Next(0, 255)
            };

            Rectangles.Add(r);
        }
    }
}