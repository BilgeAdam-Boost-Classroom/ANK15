let buttons = document.querySelectorAll(".text-button");
let displayKey = document.querySelector(".display-key");
let displayText = document.querySelector(".display-text p");
let onOffButton = document.querySelector(".button-on-off");
let displayWindow = document.querySelector(".display-window");

buttons.forEach((button) => {
  button.addEventListener("click", () => {
    if (onOffButton.classList.contains("off"))
      displayText.innerHTML = "Önce <br> Aciniz!";
    else {
      displayText.innerHTML = button.innerHTML;
      displayColor(button);
    }
  });
});

onOffButton.addEventListener("click", () => {
  buttonClass(onOffButton);
  buttonClass(displayKey);
  DisplayText();
});

const DisplayText = () => {
  if (onOffButton.classList.contains("on")) {
    displayText.innerHTML = "Acildi";
  } else {
    displayText.innerHTML = "Kapandi";
  }
};

const displayColor = (button) => {
  switch (button.innerHTML) {
    case "A":
      displayWindow.style = "background-color: red; color: white;";
      break;
    case "N":
      displayWindow.style = "background-color: white; color: red;";
      break;
    case "K":
      displayWindow.style = "background-color: blue; color: white;";
      break;
    case "1":
      displayWindow.style = "background-color: white; color: blue;";
      break;
    case "5":
      displayWindow.style = "background-color: gainsboro; color: white;";
      break;
    default:
      break;
  }
};

const buttonClass = (button) => {
  if (button.classList.contains("off")) {
    button.classList.add("on");
    button.classList.remove("off");
    displayWindow.style = "background-color: #fff; color: #333;";
  } else {
    button.classList.add("off");
    button.classList.remove("on");
    displayWindow.style = "background-color: #333; color: blue;";
  }
};
