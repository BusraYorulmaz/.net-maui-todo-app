using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal) 
        {
            _userDal= userDal;
        }
        public IDataResult<List<User>> GetAll()
        {
            if (DateTime.Now.Hour ==1)
            {
                return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            }  

            return new SuccessDataResult<List<User>>(_userDal.GetAll(),Messages.UsersListed);
        }

 
        public IDataResult< List<User>> GetAllByUserId(int id)
        {
            return new SuccessDataResult<List<User>>(  _userDal.GetAll(p=>p.ID==id));
        }

        public IDataResult< List<User>> GetAllByEmail(string email)
        {
            return new SuccessDataResult<List<User>> (_userDal.GetAll(p=>p.Email==email));
        }

         public IDataResult<List<User>> UserById(int id)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(p=>p.ID==id));
        } 

        public IDataResult<List<UserToDoDetailDto>> GetUserToDoDetails()
        {
            return new SuccessDataResult<List<UserToDoDetailDto>>( _userDal.GetUserToDoDetails());
        }

        public IResult Add(User user)
        {
            //iş kodları (business codes)
            if (user.UserName.Length<2) 
            {
                return new ErrorResult(Messages.UserNameInvalid);
            }
            _userDal.Add(user);

            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

    }
}
