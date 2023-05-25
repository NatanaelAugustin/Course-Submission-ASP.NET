function footerPosition(element, scrollHeight, innerHeight) {
    try {
        const _element = document.querySelector(element)
        const isTallerThanScreen = scrollHeight >= (innerHeight + _element.scrollHeight)

        _element.classList.toggle('position-fixed-bottom', !isTallerThanScreen)
        _element.classList.toggle('position-static', isTallerThanScreen)
    } catch { }
}
footerPosition('footer', document.body.scrollHeight, window.innerHeight)


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

const validateEmail = (event) => {
    const regEx = /^[^\s@]+@[^\s@]+\.[^\s@]+$/
    if (regEx.test(event.target.value)) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""

    } else
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Invalid email"
}

const validatePassword = (event) => {
    const regEx = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+\-=[\]{};':"\\|,.<>/?])(?=.*[^\da-zA-Z]).{8,}$/;

    if (regEx.test(event.target.value)) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "";
    } else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Invalid password";
    }
}

const validateRegisterPassword = (event) => {
    const regEx = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+\-=[\]{};':"\\|,.<>/?])(?=.*[^\da-zA-Z]).{8,}$/;

    if (regEx.test(event.target.value)) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "";
    } else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Password must meet the following requirements:<br>- At least one lowercase letter<br>- At least one uppercase letter<br>- At least one digit<br>- At least one special character from the set<br>- At least one character that is neither a letter nor a digit<br>- Minimum length of 8 characters";
    }
}

const validateConfirmPassword = (event) => {
    const confirmPassword = event.target.value;
    const passwordField = document.querySelector("#Password"); // Replace with the actual ID of the password field

    if (confirmPassword === passwordField.value) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "";
    } else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "The passwords don't match";
    }
}


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

