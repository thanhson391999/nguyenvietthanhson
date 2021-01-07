// Load data
$(document).ready(function () {
    getUser();
    $('#btnSaveAdd').click(function () {
        addUserValidate();
        if ($('#frmAddUser').valid())
            addUser();
    });
});

// home config
var homeConfig = {
    PageSize: 5,
    PageIndex: 1
};

// validate
var addUserValidate = function () {
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
                required: true
            },
            txtEmail: {
                required: true,
                email: true
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
            },
            txtConfirmPassword: {
                required: true,
                equalTo: txtPassword
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
                required: "Ngày sinh trống"
            },
            txtEmail: {
                required: "Email trống",
                email: "Định dạng Email không đúng"
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
                minlength: "Mật khẩu ít nhất 6 ký tự"
            },
            txtConfirmPassword: {
                required: "Mật khẩu xác nhận trống",
                equalTo: "Mật khẩu không trùng khớp"
            }
        }
    });
};

// Get User
var getUser = function () {
    $.ajax({
        url: atob(window.sessionStorage.getItem("urlApi")) + "/api/users/paging",//?PageIndex=1 & PageSize=10& Keyword=
        type: "GET",
        data: {
            PageIndex: homeConfig.PageIndex,
            PageSize: homeConfig.PageSize,
            Keyword: null
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
                    FirstName: item.firstName,
                    LastName: item.lastName,
                    PhoneNumber: item.phoneNumber,
                    UserName: item.userName,
                    Email: item.email
                });
            });
            $('#tblData').html(html);
        },
        error: function () {
            Swal.fire({
                icon: 'error',
                title: 'Error',
                text: 'Không thể xem danh sách người dùng'
            });
        }
    });
}

// Add User
var addUser = function () {
    var userData = {
        "FirstName": $('#txtFirstName').val(),
        "LastName": $('#txtLastName').val(),
        "PhoneNumber": $('#txtPhoneNumber').val(),
        "Dob": $('#txtDob').val(),
        "Email": $('#txtEmail').val(),
        "UserName": $('#txtUserName').val(),
        "Password": $('#txtPassword').val(),
        "ConfirmPassword": $('#txtConfirmPassword').val()
    };
    $.ajax({
        url: atob(window.sessionStorage.getItem("urlApi")) + "/api/users",
        type: "POST",
        data: JSON.stringify(userData),
        dataType: "json",
        contentType: "application/json",
        success: function (response) {
            Swal.fire({
                icon: 'success',
                title: JSON.stringify(response.responseJSON.entity),
                showConfirmButton: false,
                timer: 2000
            })
            $('.modal.fade').modal('hide');
        },
        error: function (response) {
            Swal.fire({
                icon: 'error',
                title: 'Error',
                text: JSON.stringify(response.responseJSON.message),
            });
        }
    });
};