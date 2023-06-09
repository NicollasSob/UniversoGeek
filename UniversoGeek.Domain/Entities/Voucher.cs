﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversoGeek.Core.DomainObjects;

namespace UniversoGeek.Domain.Entities
{
    public class Voucher : Entity
    {
        protected Voucher() { }
        public string Code { get; private set; }
        public decimal? Percentage { get; private set; }
        public decimal? DiscountValue { get; private set; }
        public int Amount { get; private set; }
        public DiscountTypeVoucher DiscountType { get; private set; }
        public DateTime? UsedDate { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public bool Active { get; private set; }
        public bool? Used { get; private set; }

        public bool IsValidToUse()
        {
            /*return new VoucherAtivoSpecification()
                .And(new VoucherDataSpecification())
                .And(new VoucherQuantidadeSpecification())
                .IsSatisfiedBy(this);*/

            return true;
        }

        public void SetAsUsed()
        {
            Active = false;
            Used = true;
            Amount = 0;
            UsedDate = DateTime.Now;
        }

        public void DebitAmount()
        {
            Amount -= 1;
            if (Amount == 0)
            {
                SetAsUsed();
            }
        }
    }
}
