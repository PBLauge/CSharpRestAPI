using CustomerAppDAL.UOW;

namespace CustomerAppDAL
{
    public class DALFacade
    {
        public IUnitOfWork UnitOfWork
		{
			get
			{
				return new UnitOfWork();
			}
		}

    }
}
