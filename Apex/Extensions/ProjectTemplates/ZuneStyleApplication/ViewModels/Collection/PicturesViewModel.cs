﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;

namespace ZuneStyleApplication.ViewModels
{
    /// <summary>
    /// The PicturesViewModel ViewModel class.
    /// </summary>
    public class PicturesViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PicturesViewModel"/> class.
        /// </summary>
        public PicturesViewModel()
        {
            Title = "pictures";
        }
    }
}
