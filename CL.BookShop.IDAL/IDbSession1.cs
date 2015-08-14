 

using System.Data.SqlClient;
using System.Data.Entity;

namespace CL.BookShop.IDAL
{
    public partial interface IDBSession
    {

	
		IActionGroupDAL ActionGroupDAL{get;set;}
	
		IActionInfoDAL ActionInfoDAL{get;set;}
	
		IArticel_WordsDAL Articel_WordsDAL{get;set;}
	
		IBookCommentDAL BookCommentDAL{get;set;}
	
		IBooksDAL BooksDAL{get;set;}
	
		ICartDAL CartDAL{get;set;}
	
		ICategoriesDAL CategoriesDAL{get;set;}
	
		ICheckEmailDAL CheckEmailDAL{get;set;}
	
		IDepartmentDAL DepartmentDAL{get;set;}
	
		IkeyWordsRankDAL keyWordsRankDAL{get;set;}
	
		IOrderBookDAL OrderBookDAL{get;set;}
	
		IOrdersDAL OrdersDAL{get;set;}
	
		IPublishersDAL PublishersDAL{get;set;}
	
		IR_UserInfo_ActionInfoDAL R_UserInfo_ActionInfoDAL{get;set;}
	
		IRoleDAL RoleDAL{get;set;}
	
		ISearchDetailsDAL SearchDetailsDAL{get;set;}
	
		ISettingsDAL SettingsDAL{get;set;}
	
		ISysFunDAL SysFunDAL{get;set;}
	
		IUserInfoDAL UserInfoDAL{get;set;}
	
		IUsersDAL UsersDAL{get;set;}
	
		IUserStatesDAL UserStatesDAL{get;set;}
	
		IVidoFileDAL VidoFileDAL{get;set;}
	}	
}