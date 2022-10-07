using Contracts.IServices;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
	public class RepositoryManager : IRepositoryManager
	{
		private CarFactoryContext _repositoryContext;
		private ICarRepository _carRepository;
		private ICustomerRepository _customerRepository;
		private ICategoryRepository _categoryRepository;
		private IManufactureRepository _manufactureRepository;
		private IModelRepository _modelRepository;
		private ISalesRepository _salesRepository;
		private ICountryRepository _countryRepository;
		private IPropCategoryRepository _propCategoryRepository;
		private IPropTitleRepository _propTitleRepository;
		private IPropValueRepository _propValueRepository;
		private ICarPriceRepository _carPriceRepository;
		private IAgencyRepository _agencyRepository;
		public RepositoryManager(CarFactoryContext repositoryContext)
		{
			_repositoryContext = repositoryContext;
		}
		public ICarRepository Car
		{
			get
			{
				if (_carRepository == null)
					_carRepository = new
					CarRepository(_repositoryContext);
				return _carRepository;
			}
		}
		public ICategoryRepository Category
		{
			get
			{
				if (_categoryRepository == null)
					_categoryRepository = new
					CategoryRepository(_repositoryContext);
				return _categoryRepository;
			}
		}
		public ICustomerRepository Customer
		{
			get
			{
				if (_customerRepository == null)
					_customerRepository = new
					CustomerRepository(_repositoryContext);
				return _customerRepository;
			}
		}
		public IManufactureRepository Manufacture

		{
			get
			{
				if (_manufactureRepository == null)
					_manufactureRepository = new
					ManufactureRepository(_repositoryContext);
				return _manufactureRepository;
			}
		}
		public IModelRepository Model
		{
			get
			{
				if (_modelRepository == null)
					_modelRepository = new
					ModelRepository(_repositoryContext);
				return _modelRepository;
			}
		}
		public ISalesRepository Sales
		{
			get
			{
				if (_salesRepository == null)
					_salesRepository = new
					SalesRepository(_repositoryContext);
				return _salesRepository;
			}
		}
		public ICountryRepository Country
		{
			get
			{
				if (_countryRepository == null)
					_countryRepository = new
					CountryRepository(_repositoryContext);
				return _countryRepository;
			}
		}
		public IPropCategoryRepository PropCategory
		{
			get
			{
				if (_propCategoryRepository == null)
					_propCategoryRepository = new
					PropCategoryRepository(_repositoryContext);
				return _propCategoryRepository;
			}
		}

		public IPropTitleRepository PropTitle
		{
			get
			{
				if (_propTitleRepository == null)
					_propTitleRepository = new
					PropTitleRepository(_repositoryContext);
				return _propTitleRepository;
			}
		}


		public IPropValueRepository PropValue
		{
			get
			{
				if (_propValueRepository == null)
					_propValueRepository = new
					PropValueRepository(_repositoryContext);
				return _propValueRepository;
			}
		}
		public ICarPriceRepository CarPrice
		{
			get
			{
				if (_carPriceRepository == null)
					_carPriceRepository = new
					CarPriceRepository(_repositoryContext);
				return _carPriceRepository;
			}
		}

		public IAgencyRepository Agency
		{
			get
			{
				if (_agencyRepository == null)
					_agencyRepository = new
					AgencyRepository(_repositoryContext);
				return _agencyRepository;
			}
		}
		public void Save() => _repositoryContext.SaveChanges();

	}
}
