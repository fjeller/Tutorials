using System;
using System.Collections.Generic;
using System.Text;
using MvcTest.Data.Postgres.DataAccess.Entities;

namespace MvcTest.Data.Postgres.Repositories;

public interface IMachineRepository
{
	List<Machine> GetMachines();
}
