﻿using Headstone.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headstone.Models.Events.Comment
{
    public class CommentPropertyCreated : PropertyEvent
    {
        public int CommentId { get; set; }

    }
}
