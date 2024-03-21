// Wait for the DOM content to be fully loaded before executing the script
document.addEventListener('DOMContentLoaded', function () {

    // Function to clear the input field and toggle the visibility of the clear button
    const clearInput = () => {
        // Select the input field with the class 'search_bar_input'
        const input = document.querySelector('.search_bar_input');
        // Clear the value of the input field
        input.value = '';
        // Toggle the visibility of the clear button
        toggleClearButtonVisibility();
    }

    // Function to toggle the visibility of the clear button based on input field value
    const toggleClearButtonVisibility = () => {
        // Select the input field with the class 'search_bar_input'
        const input = document.querySelector('.search_bar_input');
        // Select the clear button element by its ID 'clear-btn'
        const clearBtn = document.getElementById('clear-btn');
        // Set the display style of the clear button based on whether the input field has a value
        clearBtn.style.display = input.value ? 'block' : 'none';
    }

    // Select the clear button element by its ID 'clear-btn'
    const clearBtn = document.getElementById('clear-btn');
    // Add an event listener to the clear button to trigger the clearInput function when clicked
    clearBtn.addEventListener('click', clearInput);

    // Select the input field with the class 'search_bar_input'
    const searchInput = document.querySelector('.search_bar_input');
    // Add an event listener to the input field to trigger the toggleClearButtonVisibility function when its value changes
    searchInput.addEventListener('input', toggleClearButtonVisibility);

    // Trigger toggleClearButtonVisibility once on page load to initialize the clear button visibility
    window.addEventListener('load', toggleClearButtonVisibility);
});