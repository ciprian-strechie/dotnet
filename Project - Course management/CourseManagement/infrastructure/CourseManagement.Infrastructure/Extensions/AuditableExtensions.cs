﻿using CourseManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CourseManagement.Infrastructure.Extensions
{
    public static class AuditableExtensions
    {
        public static string GetEtag(this IAuditable entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            using var sha256Hash = SHA256.Create();
            var data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(entity.UpdatedAt.ToString()));

            return $"W/\"{Convert.ToBase64String(data)}\"";
        }
    }
}
