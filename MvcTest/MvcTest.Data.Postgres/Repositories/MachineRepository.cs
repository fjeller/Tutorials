using System;
using System.Collections.Generic;
using System.Text;
using MvcTest.Data.Postgres.DataAccess.Context;
using MvcTest.Data.Postgres.DataAccess.Entities;

namespace MvcTest.Data.Postgres.Repositories;

public class MachineRepository : IMachineRepository
{
	private readonly MachineDataContext _context;

	public MachineRepository(MachineDataContext context)
	{
		_context = context;
	}

	public List<Machine> GetMachines()
	{
		List<Machine> result = _context.Machines.ToList();

		return result;
	}

}
