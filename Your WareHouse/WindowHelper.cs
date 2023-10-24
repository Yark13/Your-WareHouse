using System;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace Your_WareHouse;

public class WindowHelper
{
    public static void CopyAllProparityAndReplacement(Window window1, Window window2)
    {
        CopySizeAndLocationAndBackground(window1, window2);

        window1.Show();

        window2.Close();
    }

    public static void CopySizeAndLocationAndBackground(Window window1, Window window2)
    {
        CopySizeAndLocation(window1, window2);

        SetWindowBackground(window1, window2.Background);
    }

    public static void CopySizeAndLocation(Window window1, Window window2)
    {
        if(window2.WindowState == WindowState.Maximized)
        {
            window1.WindowState = WindowState.Maximized;
            return;
        }

        window1.Width = window2.ActualWidth;
        window1.Height = window2.ActualHeight;
        window1.Top = window2.Top;
        window1.Left = window2.Left;
    }

    public static void SetDefaultWindowBackground(Window window)
    {
        string absolutivePath = Path.GetFullPath(@"..\..\..\Resource\Image\BackGround.jpg");

        window.Background = new ImageBrush(new BitmapImage(new Uri(@absolutivePath)));
    }

    public static void SetWindowBackground(Window window, BitmapImage image)
    {
        window.Background = new ImageBrush(image);
    }

    public static void SetWindowBackground(Window window, Brush background)
    {
        window.Background = background;
    }
}
