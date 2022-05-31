using System.Drawing;
using System.Drawing.Imaging;

const string PATH = @"input/sample.png";
const string OUTPUT_PATH = @"output/result.png";
const int SCALE = 8;

Bitmap inputImage = new Bitmap(PATH);
Bitmap outputImage = new Bitmap(inputImage.Width * SCALE, inputImage.Height * SCALE);

for (int x = 0; x < inputImage.Width; x++)
{
	for (int y = 0; y < inputImage.Height; y++)
	{
		var pixelColor = inputImage.GetPixel(x, y);
		FillPixelSquare(x * SCALE, y * SCALE, SCALE, pixelColor);
	}
}

outputImage.Save(OUTPUT_PATH, ImageFormat.Png);


void FillPixelSquare(int originX, int originY, int size, Color color)
{
	for (int x = 0; x < size; x++)
	{
		for (int y = 0; y < size; y++)
		{
			outputImage.SetPixel(originX + x, originY + y, color);
		}
	}
}