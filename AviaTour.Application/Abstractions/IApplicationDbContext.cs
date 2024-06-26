﻿using AviaTour.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaTour.Application.Abstractions
{
    public interface IApplicationDbContext
    {
        DbSet<Comment> Comments { get; set; }
        DbSet<Tour> Tours { get; set; }
        DbSet<AboutUsModel> AboutUs { get; set; }
        DbSet<Address> Address { get; set; }
        DbSet<ContactModel> Contacts { get; set; }
        DbSet<EmailAddressModel> Emails { get; set; }

        ValueTask<int> SaveChangesAsync(CancellationToken cancellationToken = default!);
    }
}
