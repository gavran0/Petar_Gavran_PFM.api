using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace PFM.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TransactionKind
    {
        dep, // Deposit
        wdw, // Withdrawal
        pmt, // Payment
        fee, // Fee
        inc, // Interest credit
        rev, // Reversal
        adj, // Adjustment
        lnd, // Loan disbursement
        lnr, // Loan repayment
        fcx, // Foreign currency exchange
        aop, // Account openning
        acl, // Account closing
        spl, // Split payment
        sal  // Salary
    }
}
