let buttons = document.querySelectorAll("button");
let isX = true;

let winCombines = [
  [1, 2, 3],
  [4, 5, 6],
  [7, 8, 9],
  [1, 4, 7],
  [2, 5, 8],
  [3, 6, 9],
  [1, 5, 9],
  [3, 5, 7],
];

buttons.forEach((button) => {
  button.addEventListener("click", (e) => {
    if (button.innerText !== "X" && button.innerText !== "O") {
      e.target.innerText = "X";
      Pc();
      GameFinish();
    } else {
      alert("Değiştiremezsin");
    }
  });
});

const Pc = () => {
  let index = Math.floor(Math.random() * 9);
  if (buttons[index].innerText == "") {
    buttons[index].innerText = "O";
  } else {
    Pc();
  }
};

function GameFinish() {
  winCombines.forEach((winCombin) => {
    const [a, b, c] = winCombin;
    const cells = [a, b, c].map(
      (num) => document.querySelector(`.b-${num}`).innerText
    );

    if (
      cells.every((cell) => cell == "X") ||
      cells.every((cell) => cell == "O")
    ) {
      alert("Oyun Bitti Kazanan ");
      //window.location.reload();
      return;
    }
  });
}

// let b1 = document.querySelector(".b-1");
// let b2 = document.querySelector(".b-2");
// let b3 = document.querySelector(".b-3");
// let b4 = document.querySelector(".b-4");
// let b5 = document.querySelector(".b-5");
// let b6 = document.querySelector(".b-6");
// let b7 = document.querySelector(".b-7");
// let b8 = document.querySelector(".b-8");
// let b9 = document.querySelector(".b-9");

//   if (
//     (b1.innerText === "X" && b2.innerText === "X" && b3.innerText === "X") ||
//     (b1.innerText === "O" && b2.innerText === "O" && b3.innerText === "O")
//   ) {
//     alert("Oyun Bitti Kazanan = " + name);
//     window.location.reload();
//   } else if (
//     (b4.innerText === "X" && b5.innerText === "X" && b6.innerText === "X") ||
//     (b4.innerText === "O" && b5.innerText === "O" && b6.innerText === "O")
//   ) {
//     alert("Oyun Bitti Kazanan = " + name);
//     window.location.reload();
//   } else if (
//     (b7.innerText === "X" && b8.innerText === "X" && b9.innerText === "X") ||
//     (b7.innerText === "O" && b8.innerText === "O" && b9.innerText === "O")
//   ) {
//     alert("Oyun Bitti Kazanan = " + name);
//     window.location.reload();
//   } else if (
//     (b1.innerText === "X" && b5.innerText === "X" && b9.innerText === "X") ||
//     (b1.innerText === "O" && b5.innerText === "O" && b9.innerText === "O")
//   ) {
//     alert("Oyun Bitti Kazanan = " + name);
//     window.location.reload();
//   } else if (
//     (b3.innerText === "X" && b5.innerText === "X" && b7.innerText === "X") ||
//     (b3.innerText === "O" && b5.innerText === "O" && b7.innerText === "O")
//   ) {
//     alert("Oyun Bitti Kazanan = " + name);
//     window.location.reload();
//   } else if (
//     (b1.innerText === "X" && b4.innerText === "X" && b7.innerText === "X") ||
//     (b1.innerText === "O" && b4.innerText === "O" && b7.innerText === "O")
//   ) {
//     alert("Oyun Bitti Kazanan = " + name);
//     window.location.reload();
//   } else if (
//     (b2.innerText === "X" && b5.innerText === "X" && b8.innerText === "X") ||
//     (b2.innerText === "O" && b5.innerText === "O" && b8.innerText === "O")
//   ) {
//     alert("Oyun Bitti Kazanan = " + name);
//     window.location.reload();
//   } else if (
//     (b3.innerText === "X" && b6.innerText === "X" && b9.innerText === "X") ||
//     (b3.innerText === "O" && b6.innerText === "O" && b9.innerText === "O")
//   ) {
//     alert("Oyun Bitti Kazanan = " + name);
//     window.location.reload();
//   }
