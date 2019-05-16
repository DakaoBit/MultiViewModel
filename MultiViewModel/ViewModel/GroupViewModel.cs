using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiViewModel.ViewModel
{
    public class GroupViewModel
    {
        public LoginViewModel Login { get; set; }
        public RegisterViewModel Register { get; set; }
    }
}