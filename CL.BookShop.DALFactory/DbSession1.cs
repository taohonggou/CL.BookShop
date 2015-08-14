 

using CL.BookShop.IDAL;
using CL.BookShop.DAL;
using System.Data.SqlClient;
using System.Data.Entity;

namespace CL.BookShop.DALFactory
{
    /// <summary>
    /// 数据访问会话层，赋值创建所有的数据操作类对象，业务层只要获取到DBSession，就拿到了所有的数据操作类的实例，让业务层与数据层解耦
    /// </summary>
    public partial class DBSession:IDBSession
    {
	
		private IActionGroupDAL _ActionGroupDAL;
        public IActionGroupDAL ActionGroupDAL
        {
            get
            {
                if(_ActionGroupDAL == null)
                {
                    _ActionGroupDAL = AbstractFactory.GetIActionGroupDALInstance();
                }
                return _ActionGroupDAL;
            }
            set { _ActionGroupDAL = value; }
        }
	
		private IActionInfoDAL _ActionInfoDAL;
        public IActionInfoDAL ActionInfoDAL
        {
            get
            {
                if(_ActionInfoDAL == null)
                {
                    _ActionInfoDAL = AbstractFactory.GetIActionInfoDALInstance();
                }
                return _ActionInfoDAL;
            }
            set { _ActionInfoDAL = value; }
        }
	
		private IArticel_WordsDAL _Articel_WordsDAL;
        public IArticel_WordsDAL Articel_WordsDAL
        {
            get
            {
                if(_Articel_WordsDAL == null)
                {
                    _Articel_WordsDAL = AbstractFactory.GetIArticel_WordsDALInstance();
                }
                return _Articel_WordsDAL;
            }
            set { _Articel_WordsDAL = value; }
        }
	
		private IBookCommentDAL _BookCommentDAL;
        public IBookCommentDAL BookCommentDAL
        {
            get
            {
                if(_BookCommentDAL == null)
                {
                    _BookCommentDAL = AbstractFactory.GetIBookCommentDALInstance();
                }
                return _BookCommentDAL;
            }
            set { _BookCommentDAL = value; }
        }
	
		private IBooksDAL _BooksDAL;
        public IBooksDAL BooksDAL
        {
            get
            {
                if(_BooksDAL == null)
                {
                    _BooksDAL = AbstractFactory.GetIBooksDALInstance();
                }
                return _BooksDAL;
            }
            set { _BooksDAL = value; }
        }
	
		private ICartDAL _CartDAL;
        public ICartDAL CartDAL
        {
            get
            {
                if(_CartDAL == null)
                {
                    _CartDAL = AbstractFactory.GetICartDALInstance();
                }
                return _CartDAL;
            }
            set { _CartDAL = value; }
        }
	
		private ICategoriesDAL _CategoriesDAL;
        public ICategoriesDAL CategoriesDAL
        {
            get
            {
                if(_CategoriesDAL == null)
                {
                    _CategoriesDAL = AbstractFactory.GetICategoriesDALInstance();
                }
                return _CategoriesDAL;
            }
            set { _CategoriesDAL = value; }
        }
	
		private ICheckEmailDAL _CheckEmailDAL;
        public ICheckEmailDAL CheckEmailDAL
        {
            get
            {
                if(_CheckEmailDAL == null)
                {
                    _CheckEmailDAL = AbstractFactory.GetICheckEmailDALInstance();
                }
                return _CheckEmailDAL;
            }
            set { _CheckEmailDAL = value; }
        }
	
		private IDepartmentDAL _DepartmentDAL;
        public IDepartmentDAL DepartmentDAL
        {
            get
            {
                if(_DepartmentDAL == null)
                {
                    _DepartmentDAL = AbstractFactory.GetIDepartmentDALInstance();
                }
                return _DepartmentDAL;
            }
            set { _DepartmentDAL = value; }
        }
	
		private IkeyWordsRankDAL _keyWordsRankDAL;
        public IkeyWordsRankDAL keyWordsRankDAL
        {
            get
            {
                if(_keyWordsRankDAL == null)
                {
                    _keyWordsRankDAL = AbstractFactory.GetIkeyWordsRankDALInstance();
                }
                return _keyWordsRankDAL;
            }
            set { _keyWordsRankDAL = value; }
        }
	
		private IOrderBookDAL _OrderBookDAL;
        public IOrderBookDAL OrderBookDAL
        {
            get
            {
                if(_OrderBookDAL == null)
                {
                    _OrderBookDAL = AbstractFactory.GetIOrderBookDALInstance();
                }
                return _OrderBookDAL;
            }
            set { _OrderBookDAL = value; }
        }
	
		private IOrdersDAL _OrdersDAL;
        public IOrdersDAL OrdersDAL
        {
            get
            {
                if(_OrdersDAL == null)
                {
                    _OrdersDAL = AbstractFactory.GetIOrdersDALInstance();
                }
                return _OrdersDAL;
            }
            set { _OrdersDAL = value; }
        }
	
		private IPublishersDAL _PublishersDAL;
        public IPublishersDAL PublishersDAL
        {
            get
            {
                if(_PublishersDAL == null)
                {
                    _PublishersDAL = AbstractFactory.GetIPublishersDALInstance();
                }
                return _PublishersDAL;
            }
            set { _PublishersDAL = value; }
        }
	
		private IR_UserInfo_ActionInfoDAL _R_UserInfo_ActionInfoDAL;
        public IR_UserInfo_ActionInfoDAL R_UserInfo_ActionInfoDAL
        {
            get
            {
                if(_R_UserInfo_ActionInfoDAL == null)
                {
                    _R_UserInfo_ActionInfoDAL = AbstractFactory.GetIR_UserInfo_ActionInfoDALInstance();
                }
                return _R_UserInfo_ActionInfoDAL;
            }
            set { _R_UserInfo_ActionInfoDAL = value; }
        }
	
		private IRoleDAL _RoleDAL;
        public IRoleDAL RoleDAL
        {
            get
            {
                if(_RoleDAL == null)
                {
                    _RoleDAL = AbstractFactory.GetIRoleDALInstance();
                }
                return _RoleDAL;
            }
            set { _RoleDAL = value; }
        }
	
		private ISearchDetailsDAL _SearchDetailsDAL;
        public ISearchDetailsDAL SearchDetailsDAL
        {
            get
            {
                if(_SearchDetailsDAL == null)
                {
                    _SearchDetailsDAL = AbstractFactory.GetISearchDetailsDALInstance();
                }
                return _SearchDetailsDAL;
            }
            set { _SearchDetailsDAL = value; }
        }
	
		private ISettingsDAL _SettingsDAL;
        public ISettingsDAL SettingsDAL
        {
            get
            {
                if(_SettingsDAL == null)
                {
                    _SettingsDAL = AbstractFactory.GetISettingsDALInstance();
                }
                return _SettingsDAL;
            }
            set { _SettingsDAL = value; }
        }
	
		private ISysFunDAL _SysFunDAL;
        public ISysFunDAL SysFunDAL
        {
            get
            {
                if(_SysFunDAL == null)
                {
                    _SysFunDAL = AbstractFactory.GetISysFunDALInstance();
                }
                return _SysFunDAL;
            }
            set { _SysFunDAL = value; }
        }
	
		private IUserInfoDAL _UserInfoDAL;
        public IUserInfoDAL UserInfoDAL
        {
            get
            {
                if(_UserInfoDAL == null)
                {
                    _UserInfoDAL = AbstractFactory.GetIUserInfoDALInstance();
                }
                return _UserInfoDAL;
            }
            set { _UserInfoDAL = value; }
        }
	
		private IUsersDAL _UsersDAL;
        public IUsersDAL UsersDAL
        {
            get
            {
                if(_UsersDAL == null)
                {
                    _UsersDAL = AbstractFactory.GetIUsersDALInstance();
                }
                return _UsersDAL;
            }
            set { _UsersDAL = value; }
        }
	
		private IUserStatesDAL _UserStatesDAL;
        public IUserStatesDAL UserStatesDAL
        {
            get
            {
                if(_UserStatesDAL == null)
                {
                    _UserStatesDAL = AbstractFactory.GetIUserStatesDALInstance();
                }
                return _UserStatesDAL;
            }
            set { _UserStatesDAL = value; }
        }
	
		private IVidoFileDAL _VidoFileDAL;
        public IVidoFileDAL VidoFileDAL
        {
            get
            {
                if(_VidoFileDAL == null)
                {
                    _VidoFileDAL = AbstractFactory.GetIVidoFileDALInstance();
                }
                return _VidoFileDAL;
            }
            set { _VidoFileDAL = value; }
        }
	}	
}