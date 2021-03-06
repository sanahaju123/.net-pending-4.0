using GroceryEmart.BusinessLayer.Interfaces;
using GroceryEmart.BusinessLayer.Services;
using GroceryEmart.BusinessLayer.Services.Repository;
using GroceryEmart.Entities;
using Moq;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace GroceryEmart.Tests.TestCases
{
    public class BoundaryTest
    {
        /// <summary>
        /// Creating Referance Variable and Mocking repository class
        /// </summary>
        private readonly ITestOutputHelper _output;
        private readonly IGroceryServices _groceryS;
        private readonly IUserGroceryServices _userGroceryS;
        private readonly IAdminGroceryServices _adminGroceryS;
        public readonly Mock<IGroceryRepository> groceryservice = new Mock<IGroceryRepository>();
        public readonly Mock<IUserGroceryRepository> userservice = new Mock<IUserGroceryRepository>();
        public readonly Mock<IAdminGroceryRepository> adminservice = new Mock<IAdminGroceryRepository>();
        private ApplicationUser _user;
        private Product _product;
        private Category _category;
        private static string type = "Boundary";
        public BoundaryTest(ITestOutputHelper output)
        {
            /// <summary>
            /// Injecting service object into Test class constructor
            /// </summary>
            _groceryS = new GroceryServices(groceryservice.Object);
            _userGroceryS = new UserGroceryServices(userservice.Object);
            _adminGroceryS = new AdminGroceryServices(adminservice.Object);
            _output = output;
        _user = new ApplicationUser()
        {
            UserId = 1,
            Name = "Uma Kumar",
            Email = "umakumarsingh@gmail.com",
            Password = "12345",
            MobileNumber = 9865253568,
            PinCode = 820003,
            HouseNo_Building_Name = "9/11",
            Road_area = "Road_area",
            City = "Gaya",
            State = "Bihar"
            };
        _product = new Product()
        {
            ProductId = 1,
            ProductName = "Samsung",
            Description = "Procesor i9, 2 GB, 32 GB SSD, Corning Grollia Glass",
            Amount = 24900.0,
            stock = 10,
            photo = "",
            CatId = 1
            };
        _category = new Category()
        {
            Id = 1,
                CatId = 1,
                Url = "~/Home",
                OpenInNewWindow = false
        };
    }
        
        /// <summary>
        /// Testfor_ValidateUserId is used to test register user is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidateUserId()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                userservice.Setup(repo => repo.Register(_user)).ReturnsAsync(_user);
                var result = await _userGroceryS.Register(_user);
                if (result.UserId == _user.UserId)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
              //Asert
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        /// <summary>
        /// Testfor_ValidateUserName is used to test register user is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidateUserName()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                userservice.Setup(repo => repo.Register(_user)).ReturnsAsync(_user);
                var result = await _userGroceryS.Register(_user);
                if (result.Name == _user.Name)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
              //Asert
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Testfor_ValidateUser_Password is used to test register user is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidateUserPassword()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                userservice.Setup(repo => repo.Register(_user)).ReturnsAsync(_user);
                var result = await _userGroceryS.Register(_user);
                if (result.Password == _user.Password)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
              //Asert
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Testfor_ValidateUser_PinCode is used to test register user is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidateUserPinCode()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                userservice.Setup(repo => repo.Register(_user)).ReturnsAsync(_user);
                var result = await _userGroceryS.Register(_user);
                if (result.PinCode == _user.PinCode)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
              //Asert
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Testfor_ValidateUser_HouseNo_Building_Name is used to test register user is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidateUserHouseNo_Building_Name()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                userservice.Setup(repo => repo.Register(_user)).ReturnsAsync(_user);
                var result = await _userGroceryS.Register(_user);
                if (result.HouseNo_Building_Name == _user.HouseNo_Building_Name)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
              //Asert
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Testfor_ValidateUser_Road_area is used to test register user is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidateUserHouseNo_Road_area()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                userservice.Setup(repo => repo.Register(_user)).ReturnsAsync(_user);
                var result = await _userGroceryS.Register(_user);
                if (result.Road_area == _user.Road_area)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
              //Asert
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Testfor_ValidateUser_City is used to test register user is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidateUser_City()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                userservice.Setup(repo => repo.Register(_user)).ReturnsAsync(_user);
                var result = await _userGroceryS.Register(_user);
                if (result.City == _user.City)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
              //Asert
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Testfor_ValidateUser_State is used to test register user is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidateUserHouseNo_State()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                userservice.Setup(repo => repo.Register(_user)).ReturnsAsync(_user);
                var result = await _userGroceryS.Register(_user);
                if (result.State == _user.State)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
              //Asert
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
          await CallAPI.saveTestResult(testName, status, type);
          return res;
        }


        /// <summary>
        /// Testfor_ValidateProductId is used to test ProductId is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidateProductId()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                adminservice.Setup(repo => repo.AddProduct(_product)).ReturnsAsync(_product);
                var result = await _adminGroceryS.AddProduct(_product);
                if (result.ProductId == _product.ProductId)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
              //Asert
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Testfor_ValidateCategoryId is used for test the CategoryId is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidateCategoryId()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                adminservice.Setup(repo => repo.AddCategory(_category)).ReturnsAsync(_category);
                var result = await _adminGroceryS.AddCategory(_category);
                if (result.Id == _category.Id)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
              //Asert
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Testfor_Validate_CatId is used to test create new category is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_CatId()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                adminservice.Setup(repo => repo.AddCategory(_category)).ReturnsAsync(_category);
                var result = await _adminGroceryS.AddCategory(_category);
                if (result.CatId == _category.CatId)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
              //Asert
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Testfor_Validate_Title is used to test create new category is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_Title()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                adminservice.Setup(repo => repo.AddCategory(_category)).ReturnsAsync(_category);
                var result = await _adminGroceryS.AddCategory(_category);
                if (result.Title == _category.Title)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
              //Asert
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Testfor_Validate_Url is used to test create new category is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_Url()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                adminservice.Setup(repo => repo.AddCategory(_category)).ReturnsAsync(_category);
                var result = await _adminGroceryS.AddCategory(_category);
                if (result.Url == _category.Url)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
              //Asert
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Testfor_Validate_OpenInNewWindow is used to test create new category is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_OpenInNewWindow()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                adminservice.Setup(repo => repo.AddCategory(_category)).ReturnsAsync(_category);
                var result = await _adminGroceryS.AddCategory(_category);
                if (result.OpenInNewWindow == _category.OpenInNewWindow)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
              //Asert
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Testfor_Validate_ProductOrder_OrderId is used to test place order is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ProductOrder_OrderId()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                groceryservice.Setup(repo => repo.PlaceOrder(_user.UserId, _product.ProductId));
                var result = await _groceryS.PlaceOrder(_user.UserId, _product.ProductId);
                if (result == true)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
              //Asert
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Testfor_ValidEmail to test email id is valid or not
        /// </summary>
        [Fact]
        public async Task<bool> Testfor_ValidEmail()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                bool isEmail = Regex.IsMatch(_user.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                //Assert
                Assert.True(isEmail);
                res = isEmail;
            }
            catch (Exception)
            {
              //Asert
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Testfor_ValidateMobileNumber is used for test mobile number is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidateMobileNumber()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                userservice.Setup(repo => repo.Register(_user)).ReturnsAsync(_user);
                var result = await _userGroceryS.Register(_user);
                var actualLength = _user.MobileNumber.ToString().Length;
                if (result.MobileNumber.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
              //Asert
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }
    }
}
