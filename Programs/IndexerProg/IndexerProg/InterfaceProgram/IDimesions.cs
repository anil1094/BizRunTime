using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.OOPs_Concepts
{
    interface IDimesions
    {
        float getLength();
        float getWidth();
    }
    class BOX :IDimesions
    {
        float lengthInch;
        float WidthInch;
        public BOX(float length,float width)
        {
            lengthInch = length;
            WidthInch = width;
        }
        float IDimesions.getLength()
        {
            return lengthInch;
        }
        float IDimesions.getWidth()
        {
            return WidthInch;
        }
    }
}
