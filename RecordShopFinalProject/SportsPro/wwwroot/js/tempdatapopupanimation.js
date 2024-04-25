// Closes the temp data message
function closeCRUDMessage() {
    var errorMessage = document.getElementById("CRUDMessage");
    errorMessage.classList.add("crud_message_slide_out"); // Add exit animation class

    setTimeout(function () {
        errorMessage.style.display = "none"; // Hide the error message after the animation completes
    }, 500); // Adjust timeout to match your animation duration
}

// Automatically close the error message after 8 seconds
setTimeout(function () {
    closeCRUDMessage();
}, 8000); // 1000 milliseconds = 1 second