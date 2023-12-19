using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Making_a_Player_Class
{
    internal class Button
    {
        Texture2D rectTex;
        SpriteFont font;
        string text;
        Rectangle rect;
        SoundEffect soundEffect;
        float opacity, prevOpacity;

        //Returns true if clicked on button
        public bool Update(MouseState mouse)
        {
            bool clicked = false;
            if (rect.Contains(mouse.X, mouse.Y))
            {
                opacity = 0.7f;
                if (prevOpacity != opacity)
                    soundEffect.Play();
                clicked = mouse.LeftButton == ButtonState.Pressed;
            }
            else
            {
                opacity = 1;
            }
            prevOpacity = opacity;
            return clicked;
        }
        public void Draw(SpriteBatch sprite)
        {
            sprite.Draw(rectTex, rect, Color.Blue * opacity);
            sprite.DrawString(font, text, new Vector2(rect.X+10, rect.Y +10), Color.White);
        }
    }
}
