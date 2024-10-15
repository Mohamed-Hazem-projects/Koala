// Run the function once on page load to validate any pre-filled values
$(document).ready(function () {
    checkPasswordRules();
    checkPasswordsMatch();
});

function labeleffect(element) {
    $(element).toggleClass('touched', !!$(element).val());
}

$("input").on('input', function () {
    labeleffect(this);
});

$(".fa-eye").hide();
function showOrHidePassword() {
    $(".fa-eye").toggle();
    $(".fa-eye-slash").toggle();
    if ($('input.passwordstuff').attr('type') == 'password') {
        $('input.passwordstuff').attr('type', 'text');
    } else {
        $('input.passwordstuff').attr('type', 'password');
    }
}

// Bind the password and confirm password input events to trigger the validation check
$('#Password, #ConfirmPassword').on('input', function () {
    checkPasswordRules();
    checkPasswordsMatch();
});

// Password validation function
function checkPasswordRules() {
    var password = $('#Password').val();

    // Validation Conditions
    var minLength = password.length >= 8;
    var hasLowerUpper = /[a-z]/.test(password) && /[A-Z]/.test(password);
    var hasNumber = /\d/.test(password);
    var hasSpecialChar = /[^a-zA-Z0-9]/.test(password);

    // Update UI for minimum length rule
    updateRuleStatus('#pwMinLength', minLength);

    // Update UI for lower/upper case rule
    updateRuleStatus('#lowerUpper', hasLowerUpper);

    // Update UI for number rule
    updateRuleStatus('#numbermin', hasNumber);

    // Update UI for special character rule
    updateRuleStatus('#specialChar', hasSpecialChar);

    // Return true if all rules are valid
    return minLength && hasLowerUpper && hasNumber && hasSpecialChar;
}

// Function to check if passwords match
function checkPasswordsMatch() {
    var password = $('#Password').val();
    var confirmPassword = $('#ConfirmPassword').val();
    var errorMessage = $('#confirmPasswordError'); // Select the error message span

    // If passwords don't match, display the error and add error class
    if (password !== confirmPassword) {
        $('#ConfirmPassword').addClass('password-error');
        errorMessage.text("Passwords do not match").show(); // Show the error message
        return false;
    } else {
        $('#ConfirmPassword').removeClass('password-error');
        errorMessage.text("").hide(); // Clear the error message
        return true;
    }
}

// Update rule status UI
function updateRuleStatus(ruleId, isValid) {
    var ruleElement = $(ruleId);
    var icon = ruleElement.find('i');

    // Toggle the class based on validation status
    ruleElement.toggleClass('valid greenify', isValid);

    // Toggle icon classes (check for valid, cross for invalid)
    if (isValid) {
        icon.removeClass('fa-x').addClass('fa-check');
    } else {
        icon.removeClass('fa-check').addClass('fa-x');
    }
}

// Prevent form submission if password validations fail or passwords don't match
$('form').on('submit', function (e) {
    var isPasswordValid = checkPasswordRules();
    var doPasswordsMatch = checkPasswordsMatch();

    // If any validation fails, prevent form submission
    if (!isPasswordValid || !doPasswordsMatch) {
        e.preventDefault(); // Stop form submission
        return false;
    }
});
