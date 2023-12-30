using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace GlyphMinimal
{
    public static class Helper
    {
        public static GlyphRun Run(string text, GlyphTypeface typeFace, int renderingEmSize, Point origin)
        {
            Point[] glyphOffsets = new Point[text.Length];
            ushort[] glyphIndexes = new ushort[text.Length];
            double[] AdvanceWidths = new double[text.Length];
            double off = 0;
            double offy = 0;
            for (int i = 0; i < text.Length; i++)
            {
                ushort ind = typeFace.CharacterToGlyphMap[text[i]];
                glyphIndexes[i] = ind;
                glyphOffsets[i] = new Point(off, offy);
                AdvanceWidths[i] = typeFace.AdvanceWidths[glyphIndexes[i]] * renderingEmSize;
            }
            return NewGlyphRun(glyphIndexes, origin, AdvanceWidths, glyphOffsets, renderingEmSize, typeFace);
        }

        private static GlyphRun NewGlyphRun(ushort[] glyphIndexes, Point origin, double[] advanceWidths, Point[] offsets, int renderingEmSize, GlyphTypeface typeFace)
        {
            return new GlyphRun(typeFace,
                0,
                false,
                renderingEmSize,
                2.5f,
                glyphIndexes,
                origin,
                advanceWidths,
                offsets,
                null, null, null, null, null);
        }
    }
}
