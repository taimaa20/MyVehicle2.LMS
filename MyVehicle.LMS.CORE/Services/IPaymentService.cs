using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
   public interface IPaymentService
    {
        public List<Payment> GetAllPayments();

        public bool InsertPayment(Payment payment);
        public bool UpdatePayment(Payment payment);
        public bool DeletePayment(Payment payment);
        public Payment GetAllPaymentsById(Payment payment);
    }
}
