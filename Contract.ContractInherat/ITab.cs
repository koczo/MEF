using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;

namespace Contract.ContractInherat
{
    [InheritedExport(typeof (ITab))]
    public interface ITab
    {
        string TabName { get; }
        List<Privilege> Privileges { get; }
    }

    public enum Privilege
    {
        Admin,
        User
    }
}
