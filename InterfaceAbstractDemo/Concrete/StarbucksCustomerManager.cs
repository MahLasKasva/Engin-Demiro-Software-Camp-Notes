using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;
        private NeroCustomerManager neroCustomerManager;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public StarbucksCustomerManager(NeroCustomerManager neroCustomerManager)
        {
            this.neroCustomerManager = neroCustomerManager;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }

            throw new Exception("Not a valid person");
        }
    }
}
