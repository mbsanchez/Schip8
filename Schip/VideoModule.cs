using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schip
{
    class VideoModule
    {
        #region Declaracion de constantes
        public enum VideoMode { Chip8Mode, SChipMode };
        private const int HORZ_RES_CHIP8_MODE = 64;
        private const int VERT_RES_CHIP8_MODE = 32;
        private const int HORZ_RES_SCHIP_MODE = 128;
        private const int VERT_RES_SCHIP_MODE = 64;
        #endregion

        #region Definicion de atributos
        private VideoMode currentMode;
        private VideoLine128[] display;
        private int currentHorzRes;
        private int currentVertRes;
        #endregion

        #region metodos getter
        public VideoMode CurrentMode 
        { 
            get 
            { 
                return currentMode; 
            }
            set 
            { 
                currentMode = value;
                switch (value)
                {
                    case VideoMode.Chip8Mode:
                        currentHorzRes = HORZ_RES_CHIP8_MODE;
                        currentVertRes = VERT_RES_CHIP8_MODE;
                        break;
                    case VideoMode.SChipMode:
                        currentHorzRes = HORZ_RES_SCHIP_MODE;
                        currentVertRes = VERT_RES_SCHIP_MODE;
                        break;
                }
            } 
        }

        public int CurrentHorzRes { get { return currentHorzRes; } }
        public int CurrentVertRes { get { return currentVertRes; } }
        public VideoLine128[] Display { get { return display; } }
        #endregion

        #region Constructores
        public VideoModule()
        {
            CurrentMode = VideoMode.Chip8Mode;
            display = new VideoLine128[VERT_RES_SCHIP_MODE];

            //Crear cada una de las lineas de video
            for (int i = 0; i < display.Length; i++)
                display[i] = new VideoLine128();
        }
        #endregion

        #region Otros metodos
        public byte Draw(MemoryModule memory, ushort memAddress, byte posx, byte posy, byte height)
        {
            byte collision = 0;
            byte width = 8;
            bool extendedSprite = false;
            ushort mask = 0x80;


            if (height == 0)
            {
                height = 16;
                if (currentMode == VideoMode.SChipMode)
                {
                    width = 16;
                    extendedSprite = true;
                    mask = 0x8000;
                }
            }
            posx &= (byte)(currentHorzRes - 1);
            posy &= (byte)(currentVertRes - 1);


            for (int y = 0; y < height; y++)
            {
                if (posy + y >= currentVertRes)
                    continue;
                //Extraer la informacion del sprite de memoria
                uint sprLineAddress = (ushort)(memAddress + (y << (extendedSprite?1:0)) );
                ushort sprLine = memory.ReadByte(sprLineAddress);

                if(extendedSprite)
                    sprLine = (ushort)(sprLine << 8 | memory.ReadByte(sprLineAddress+1));   
                
                for (int x = 0; x < width; x++)
                {
                    if (posx + x >= currentHorzRes)
                        continue;
                    if ((sprLine & (mask >> x)) != 0) {
                        if (collision == 0 && display[posy + y].IsPixelActive(posx + x))
                            collision = 1;
                        display[posy + y].XorPixel(posx + x, 1);
                    } 
                }
            }

            return collision;
        }

        public void ClearScreen()
        {
            for (int i = 0; i < currentVertRes; i++)
                display[i].Erase();
        }

        public void Reset()
        {
            for (int i = 0; i < currentVertRes; i++)
                display[i].Erase();
            CurrentMode = VideoMode.Chip8Mode;
        }

        public void ScrollDown(uint lines)
        {
            if (lines >= currentVertRes)
                ClearScreen();
            else
            {
                //Desplazar las lineas Hacia abajo empezamos de abajo hacia arriba
                for (int i = currentVertRes - 1; i >= 0; i--)
                {
                    if (i < lines)
                    {
                        display[i] = new VideoLine128();
                    }
                    else{
                        display[i] = display[i-lines];
                    }
                }
            }
        }

        public void ScrollLeft(uint cols)
        {
            if(cols > currentHorzRes)
                ClearScreen();
            else{
                for (int i = 0; i < currentVertRes; i++)
                    display[i].Shl((int)cols);
            }
        }

        public void ScrollRight(uint cols)
        {
            if (cols > currentHorzRes)
                ClearScreen();
            else
            {
                for (int i = 0; i < currentVertRes; i++)
                    display[i].Shr((int)cols);
            }
        }
        #endregion
    }
}
