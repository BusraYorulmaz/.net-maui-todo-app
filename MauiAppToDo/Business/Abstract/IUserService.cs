using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        // IResult -> void 
        //IDataResult -> hem işlem sonucunu hem de döndüreceği şeyi içeren bir yapı görevindedir.
        //Buradaki User datamızın kendisi 
        
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetAllByUserId(int id);
        IDataResult<List<User>> GetAllByEmail(string email);
        IDataResult<List<UserToDoDetailDto>> GetUserToDoDetails();
        IDataResult<List<User>> UserById(int id);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);



    }
}
