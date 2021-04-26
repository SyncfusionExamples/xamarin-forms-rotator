using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RotatorSample
{
    public class RotatorModel
    {
        public RotatorModel(string imagestr)
        {
            Image = imagestr;
        }
        private String _image;
        public String Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}