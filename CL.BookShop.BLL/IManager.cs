using CL.BookShop.IBLL;
using CL.BookShop.Model;

namespace CL.BookShop.BLL
{

    public partial class ActionGroupService :BaseService<ActionGroup>,IActionGroupService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.ActionGroupDAL;
        }
    }   
	
	public partial class ActionInfoService :BaseService<ActionInfo>,IActionInfoService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.ActionInfoDAL;
        }
    }   
	
	public partial class Articel_WordsService :BaseService<Articel_Words>,IArticel_WordsService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.Articel_WordsDAL;
        }
    }   
	
	public partial class BookCommentService :BaseService<BookComment>,IBookCommentService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.BookCommentDAL;
        }
    }   
	
	public partial class BooksService :BaseService<Books>,IBooksService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.BooksDAL;
        }
    }   
	
	public partial class CartService :BaseService<Cart>,ICartService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.CartDAL;
        }
    }   
	
	public partial class CategoriesService :BaseService<Categories>,ICategoriesService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.CategoriesDAL;
        }
    }   
	
	public partial class CheckEmailService :BaseService<CheckEmail>,ICheckEmailService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.CheckEmailDAL;
        }
    }   
	
	public partial class DepartmentService :BaseService<Department>,IDepartmentService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.DepartmentDAL;
        }
    }   
	
	public partial class keyWordsRankService :BaseService<keyWordsRank>,IkeyWordsRankService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.keyWordsRankDAL;
        }
    }   
	
	public partial class OrderBookService :BaseService<OrderBook>,IOrderBookService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.OrderBookDAL;
        }
    }   
	
	public partial class OrdersService :BaseService<Orders>,IOrdersService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.OrdersDAL;
        }
    }   
	
	public partial class PublishersService :BaseService<Publishers>,IPublishersService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.PublishersDAL;
        }
    }   
	
	public partial class R_UserInfo_ActionInfoService :BaseService<R_UserInfo_ActionInfo>,IR_UserInfo_ActionInfoService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.R_UserInfo_ActionInfoDAL;
        }
    }   
	
	public partial class RoleService :BaseService<Role>,IRoleService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.RoleDAL;
        }
    }   
	
	public partial class SearchDetailsService :BaseService<SearchDetails>,ISearchDetailsService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.SearchDetailsDAL;
        }
    }   
	
	public partial class SettingsService :BaseService<Settings>,ISettingsService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.SettingsDAL;
        }
    }   
	
	public partial class SysFunService :BaseService<SysFun>,ISysFunService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.SysFunDAL;
        }
    }   
	
	public partial class UserInfoService :BaseService<UserInfo>,IUserInfoService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.UserInfoDAL;
        }
    }   
	
	public partial class UsersService :BaseService<Users>,IUsersService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.UsersDAL;
        }
    }   
	
	public partial class UserStatesService :BaseService<UserStates>,IUserStatesService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.UserStatesDAL;
        }
    }   
	
	public partial class VidoFileService :BaseService<VidoFile>,IVidoFileService
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.VidoFileDAL;
        }
    }   
	
}