
function footerPosition(element, scrollHeight, innerHeight) {
    try {
        const _element = document.querySelector(element)
        const isTallerThanScreen = scrollHeight >= (innerHeight + _element.scrollHeight)

        _element.classList.toggle('position-fixed-bottom', !isTallerThanScreen)
        _element.classList.toggle('position-static', isTallerThanScreen)
    } catch { }
}
footerPosition('footer', document.body.scrollHeight, window.innerHeight);

function toggleMenu(attribute) {
    try {
        const toggleBtn = document.querySelector(attribute)
        toggleBtn.addEventListener('click', function () {
            const element = document.querySelector(toggleBtn.getAttribute('data-target'))

            if (!element.classList.contains('open-menu')) {
                element.classList.add('open-menu')
                toggleBtn.classList.add('btn-outline-dark')
                toggleBtn.classList.add('btn-toggle-white')
            }

            else {
                element.classList.remove('open-menu')
                toggleBtn.classList.remove('btn-outline-dark')
                toggleBtn.classList.remove('btn-toggle-white')
            }
        })
    } catch { }
}
toggleMenu('[data-option="toggle"]')

// Validate Email

const validateEmail = (event) => {
    const regEx = /^[^\s@]+@[^\s@]+\.[^\s@]+$/
    if (regEx.test(event.target.value)) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""

    } else
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Invalid email"
}
// validate password for login page

const validatePassword = (event) => {
    const regEx = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+\-=[\]{};':"\\|,.<>/?])(?=.*[^\da-zA-Z]).{8,}$/;

    if (regEx.test(event.target.value)) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "";
    } else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Invalid password";
    }
}
// validate password for register page
const validateRegisterPassword = (event) => {
    const regEx = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+\-=[\]{};':"\\|,.<>/?])(?=.*[^\da-zA-Z]).{8,}$/;

    if (regEx.test(event.target.value)) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "";
    } else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Password must meet the following requirements:<br>- At least one lowercase letter<br>- At least one uppercase letter<br>- At least one digit<br>- At least one special character from the set<br>- At least one character that is neither a letter nor a digit<br>- Minimum length of 8 characters";
    }
}
// validate confirm password for login page
const validateConfirmPassword = (event) => {
    const confirmPassword = event.target.value;
    const passwordField = document.querySelector("#Password"); 

    if (confirmPassword === passwordField.value) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "";
    } else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "The passwords don't match";
    }
}

// validatet textboxes for all the registerpage
const validateText = (event) => {
    if (event.target.value.length >= 2) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""

    } else
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Invalid length"
}

// Smooth carousel navigation
var carouselElements = document.querySelectorAll('.carousel');
carouselElements.forEach(function (carouselElement) {
    new bootstrap.Carousel(carouselElement, {
        interval: 5000,
        wrap: true,
        pause: 'hover',
    });
});

// Text showing up when submitting contact-message

document.addEventListener('DOMContentLoaded', function () {
  const form = document.getElementById('contactForm');
  const submitButton = document.getElementById('contactSubmitButton');
  const submitMessage = document.getElementById('contactSubmitMessage');

  form.addEventListener('submit', function (event) {
    event.preventDefault();
    submitMessage.style.display = 'block';
    form.reset();

    setTimeout(function () {
      submitMessage.style.display = 'none';
    }, 3000);
  });
});