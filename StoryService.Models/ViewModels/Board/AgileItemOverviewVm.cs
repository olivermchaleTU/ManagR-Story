﻿using StoryService.Models.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoryService.Models.ViewModels
{
    public class AgileItemOverviewVm
    {
        public Guid Id { get; set; }
        public Guid AssigneeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Order { get; set; }
        public string AssigneeName { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public bool IsComplete { get; set; }
    }
}
