namespace KnightsApp
{
    public static class BitmapRenderer
    {
        public static int[] Generate(int gridSize, int cellSize)
        {
            int width = gridSize * cellSize;
            int height = gridSize * cellSize;
            int[] pixels = new int[width * height * 4];
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    bool isBlue = row > col;
                    byte r = isBlue ? (byte)0 : (byte)255;
                    byte g = 0;
                    byte b = isBlue ? (byte)255 : (byte)0;
                    byte a = 255;
                    for (int py = 0; py < cellSize; py++)
                    {
                        for (int px = 0; px < cellSize; px++)
                        {
                            int x = col * cellSize + px;
                            int y = row * cellSize + py;
                            int index = (y * width + x) * 4;
                            pixels[index + 0] = r;
                            pixels[index + 1] = g;
                            pixels[index + 2] = b;
                            pixels[index + 3] = a;
                        }
                    }
                }
            }
            return pixels;
        }
    }
}
