using Raylib_cs;
using StefanBestammerTetris;

Raylib.InitWindow(800, 600, "Stefan Bestämmer Tetris");
Raylib.SetTargetFPS(60);

Block myBlock = new Block(400, 50, 60,Color.Black);

while (!Raylib.WindowShouldClose())
{
    myBlock.Update();
    
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.RayWhite);
    
    myBlock.Draw();
    
    Raylib.EndDrawing();
}

Raylib.CloseWindow();

