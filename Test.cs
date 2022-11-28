public class Test
{
    public void Query()
    {
        string sql = "/*sql*/select * from users where user_name  = 'admin' and is_active = 1 ";
    }

    public void Insert()
    {
        var sql = "/*sql*/insert into users values(1,'admin')";
    }
}