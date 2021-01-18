// User config
var userConfig = {
    PageSize: 1,
    PageIndex: 1
};
// common (promise object)
var deferred = $.Deferred();
// save user from function get user by id
var user;
// controller
var userController = {
    init: function () {
        // Load data
        userController.getUser();
        // Add User
        $('#btnSaveAdd').click(function () {
            userController.addUserValidate();
            if ($('#frmAddUser').valid())
                userController.addUser();
        });
        // Update User
        $('#btnSaveUpdate').click(function () {
            userController.updateUserValidate();
            if ($('#frmUpdateUser').valid()) {
                var id = $('#btnUpdate').data('id');
                userController.updateUser(id);
            };
        });
        // Filter User
        $('#btnSearch').click(function () {
            var keyword = $('#txtSearch').val();
            userController.searchUser(keyword);
        });
        $('#txtSearch').off('keypress').on('keypress', function (e) {
            if (e.which == 13) {
                var keyword = $('#txtSearch').val();
                userController.searchUser(keyword);
            }
        });
    },
    // Get User
    getUser: async function (changePageSize, keyword) {
        await $.ajax({
            url: atob(window.sessionStorage.getItem("urlApi")) + "/api/users/paging",
            type: "GET",
            data: {
                PageIndex: userConfig.PageIndex,
                PageSize: userConfig.PageSize,
                Keyword: keyword
            },
            dataType: "json",
            headers: {
                'Authorization': 'Bearer ' + window.sessionStorage.getItem("Token")
            },
            success: function (response) {
                var data = response.items;
                var html = '';
                var template = $('#data-template').html();
                $.each(data, function (i, item) {
                    html += Mustache.render(template, {
                        Id: item.id,
                        FirstName: item.firstName,
                        LastName: item.lastName,
                        Dob: new moment(item.dob).format('MM-DD-YYYY'),
                        PhoneNumber: item.phoneNumber,
                        UserName: item.userName,
                        Email: item.email
                    });
                });
                $('#tblData').html(html);
                userController.paging(response.totalRecord, function () {
                    userController.getUser(false, keyword);
                }, changePageSize);
                deferred.resolve();
            },
            error: function () {
                Swal.fire({
                    icon: 'error',
                    title: 'Error',
                    text: 'Không thể xem danh sách người dùng'
                });
                deferred.reject();
            }
        });
        return deferred.promise();
    },
    // Add User
    addUser: async function () {
        var userData = {
            "FirstName": $('#txtFirstNameAdd').val(),
            "LastName": $('#txtLastNameAdd').val(),
            "PhoneNumber": $('#txtPhoneNumberAdd').val(),
            "Dob": $('#txtDobAdd').val(),
            "Email": $('#txtEmailAdd').val(),
            "UserName": $('#txtUserNameAdd').val(),
            "Password": $('#txtPasswordAdd').val(),
            "ConfirmPassword": $('#txtConfirmPasswordAdd').val()
        };
        await $.ajax({
            url: atob(window.sessionStorage.getItem("urlApi")) + "/api/users",
            type: "POST",
            data: JSON.stringify(userData),
            dataType: "json",
            contentType: "application/json",
            success: function (response) {
                Swal.fire({
                    icon: 'success',
                    title: JSON.stringify(response.entity).replace(/\"/g, ""),
                    showConfirmButton: false,
                    timer: 2000
                })
                $('#modalAddUser').modal('hide');
                $('#frmAddUser').validate().destroy();
                $('#frmAddUser')[0].reset();
                userController.getUser(true);
            },
            error: function (response) {
                Swal.fire({
                    icon: 'error',
                    title: 'Error',
                    text: JSON.stringify(response.responseJSON.message).replace(/\"/g, ""),
                });
            }
        });
    },
    // Get User By Id
    getUserById: async function (id) {
        await $.ajax({
            url: atob(window.sessionStorage.getItem("urlApi")) + "/api/users/" + id,
            type: 'GET',
            headers: {
                'Authorization': 'Bearer ' + window.sessionStorage.getItem("Token")
            }
        }).done(function (response) {
            user = response;
            deferred.resolve();
        }).fail(function (response) {
            user = response;
            deferred.reject();
        });
        return deferred.promise();
    },
    // Update User
    setData: async function () {
        var id = $('#btnUpdate').data('id');
        var done = function () {
            $('#modalUpdateUser').modal('show');
            $('#txtFirstNameUpdate').val(user.entity.firstName);
            $('#txtLastNameUpdate').val(user.entity.lastName);
            $('#txtPhoneNumberUpdate').val(user.entity.phoneNumber);
            // format day = yyyy/mm/dd
            var dobFormat = new moment(user.entity.dob).format('YYYY-MM-DD');
            $('#txtDobUpdate').val(dobFormat);
            $('#txtEmailUpdate').val(user.entity.email);
        };
        var fail = function () {
            Swal.fire({
                icon: 'error',
                title: 'Error',
                text: JSON.stringify(user.message).replace(/\"/g, ""),
            });
        };
        await userController.getUserById(id).then(done, fail);
    },
    updateUser: async function (id) {
        var userData = {
            "FirstName": $('#txtFirstNameUpdate').val(),
            "LastName": $('#txtLastNameUpdate').val(),
            "PhoneNumber": $('#txtPhoneNumberUpdate').val(),
            "Dob": $('#txtDobUpdate').val(),
            "Email": $('#txtEmailUpdate').val()
        };
        await $.ajax({
            url: atob(window.sessionStorage.getItem("urlApi")) + "/api/users/" + id,
            type: "PUT",
            data: JSON.stringify(userData),
            dataType: "json",
            contentType: "application/json",
            headers: {
                'Authorization': 'Bearer ' + window.sessionStorage.getItem("Token")
            },
            success: function (response) {
                var entity = JSON.stringify(response.entity).replace(/\"/g, "");
                Swal.fire({
                    icon: 'success',
                    title: entity,
                    showConfirmButton: false,
                    timer: 2000
                })
                $('#modalUpdateUser').modal('hide');
                $('#frmUpdateUser').validate().destroy();
                $('#frmUpdateUser')[0].reset();
                userController.getUser();
            },
            error: function (response) {
                Swal.fire({
                    icon: 'error',
                    title: 'Error',
                    text: JSON.stringify(response.message).replace(/\"/g, ""),
                });
            }
        });
    },
    // Delete User
    deleteUser: async function (id) {
        await $.ajax({
            url: atob(window.sessionStorage.getItem("urlApi")) + "/api/users/" + id,
            type: "DELETE",
            headers: {
                'Authorization': 'Bearer ' + window.sessionStorage.getItem("Token")
            },
            success: function (response) {
                var entity = JSON.stringify(response.entity).replace(/\"/g, "");
                Swal.fire({
                    icon: 'success',
                    title: entity,
                    showConfirmButton: false,
                    timer: 2000
                })
                userController.getUser(true);
            },
            error: function (response) {
                Swal.fire({
                    icon: 'error',
                    title: 'Error',
                    text: JSON.stringify(response.message).replace(/\"/g, ""),
                });
            }
        });
    },
    deleteConfirm: function () {
        swal.fire({
            title: 'Bạn chắc chắn?',
            text: "Bạn sẽ không thể hoàn lại dữ liệu",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#28a745',
            cancelButtonColor: '#dc3545',
            confirmButtonText: 'Xác nhận',
            cancelButtonText: 'Hủy',
            reverseButtons: true
        }).then((result) => {
            if (JSON.stringify(result.value) == "true") {
                var id = $('#btnDelete').data('id');
                userController.deleteUser(id);
            }
        })
    },
    // validate
    validateDob: function () {
        $.validator.addMethod("notover100years", function (datePicker) {
            var dateNow = new Date().toLocaleDateString().split('/');
            datePicker = datePicker.split('-');
            if (parseInt(datePicker[0]) >= parseInt(dateNow[2]) - 100)
                return true;
            return false;
        });
        $.validator.addMethod("notoverdatenow", function (datePicker) {
            var dateNow = new Date().toLocaleDateString().split('/');
            datePicker = datePicker.split('-');
            if (parseInt(datePicker[0]) <= parseInt(dateNow[2]))
                return true;
            return false;
        });
    },
    validateEmail: function () {
        $.validator.addMethod("emailformat", function (email) {
            var regex = /^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$/;
            if (regex.test(email))
                return true;
            return false;
        });
    },
    validatePassword: function () {
        $.validator.addMethod("passwordcheck", function (password) {
            if (/^[A-Za-z0-9\d@$!%*#?&=!\-@._*]*$/.test(password) && /[a-z]/.test(password) && /\d/.test(password) && /[A-Z]/.test(password) && /[@$!%*#?&]/.test(password))
                return true;
            return false;
        });
    },
    addUserValidate: function () {
        userController.validateDob();
        userController.validateEmail();
        userController.validatePassword();
        $('#frmAddUser').validate({
            rules: {
                txtFirstName: {
                    required: true,
                    maxlength: 200
                },
                txtLastName: {
                    required: true,
                    maxlength: 200
                },
                txtDob: {
                    required: true,
                    notover100years: true,
                    notoverdatenow: true
                },
                txtEmail: {
                    required: true,
                    emailformat: true,
                },
                txtPhoneNumber: {
                    required: true,
                    number: true,
                    rangelength: [10, 10]
                },
                txtUserName: {
                    required: true,
                    maxlength: 200
                },
                txtPassword: {
                    required: true,
                    maxlength: 200,
                    minlength: 6,
                    passwordcheck: true
                },
                txtConfirmPassword: {
                    required: true,
                    equalTo: '#txtPasswordAdd'
                }
            },
            messages: {
                txtFirstName: {
                    required: "Tên trống",
                    maxlength: "Tên không quá 200 ký tự"
                },
                txtLastName: {
                    required: "Họ trống",
                    maxlength: "Họ không quá 200 ký tự"
                },
                txtDob: {
                    required: "Ngày sinh trống",
                    notover100years: "Ngày sinh không vượt quá 100 năm",
                    notoverdatenow: "Ngày sinh không vượt quá năm hiện tại",
                },
                txtEmail: {
                    required: "Email trống",
                    emailformat: "Email không hợp lệ"
                },
                txtPhoneNumber: {
                    required: "Số điện thoại trống",
                    number: "Số điện thoại phải là số",
                    rangelength: "Số điện thoại phải là 10 số"
                },
                txtUserName: {
                    required: "Tên đăng nhập trống",
                    maxlength: "Tên đăng nhập không quá 200 ký tự"
                },
                txtPassword: {
                    required: "Mật khẩu trống",
                    maxlength: "Mật khẩu không quá 200 ký tự",
                    minlength: "Mật khẩu ít nhất 6 ký tự",
                    passwordcheck: "Mật khẩu phải chứa cả chữ, số và kí tự đặt biệt trong đó có ít nhất 1 chữ in hoa và 1 chữ in thường"
                },
                txtConfirmPassword: {
                    required: "Mật khẩu xác nhận trống",
                    equalTo: "Mật khẩu không trùng khớp"
                }
            }
        });
    },
    updateUserValidate: function () {
        userController.validateDob();
        userController.validateEmail();
        $('#frmUpdateUser').validate({
            rules: {
                txtFirstName: {
                    required: true,
                    maxlength: 200
                },
                txtLastName: {
                    required: true,
                    maxlength: 200
                },
                txtDob: {
                    required: true,
                    notover100years: true,
                    notoverdatenow: true
                },
                txtEmail: {
                    required: true,
                    emailformat: true,
                },
                txtPhoneNumber: {
                    required: true,
                    number: true,
                    rangelength: [10, 10]
                },
            },
            messages: {
                txtFirstName: {
                    required: "Tên trống",
                    maxlength: "Tên không quá 200 ký tự"
                },
                txtLastName: {
                    required: "Họ trống",
                    maxlength: "Họ không quá 200 ký tự"
                },
                txtDob: {
                    required: "Ngày sinh trống",
                    notover100years: "Ngày sinh không vượt quá 100 năm",
                    notoverdatenow: "Ngày sinh không vượt quá năm hiện tại",
                },
                txtEmail: {
                    required: "Email trống",
                    emailformat: "Email không hợp lệ"
                },
                txtPhoneNumber: {
                    required: "Số điện thoại trống",
                    number: "Số điện thoại phải là số",
                    rangelength: "Số điện thoại phải là 10 số"
                },
            }
        });
    },
    // Pagination
    paging: function (totalRow, callBack, changePageSize) {
        var totalPages = Math.ceil(totalRow / userConfig.PageSize);
        if (totalPages > 1) {
            if ($('#pagination a').length == 0 || changePageSize == true) {
                $('#pagination').empty();
                $('#pagination').removeData("twbs-pagination");
                $('#pagination').unbind("page");
            }
            $('#pagination').twbsPagination({
                totalPages: totalPages,
                visiblePages: 5,
                first: "Đầu",
                prev: "Trước",
                next: "Tiếp",
                last: "Cuối",
                onPageClick: function (event, pageIndex) {
                    userConfig.PageIndex = pageIndex;
                    setTimeout(callBack, 200);
                }
            });
        }
        else
            $('#pagination').twbsPagination('destroy');
    },
    // Filter
    searchUser: function (keyword) {
        userConfig.PageIndex = 1;
        userController.getUser(true, keyword);
    }
}
userController.init();