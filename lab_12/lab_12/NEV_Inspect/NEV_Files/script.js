//1.=================================================================
console.log("First Task");
const numbers = [1, 2, 3, 4, 5];
const [y] = numbers;

console.log(y);

//2.=================================================================
console.log("\nSecond Task");

let user = {
  name: "Evgeha",
  age: 18
};

let admin = { admin: true, ...user }
console.log(admin);

//3.=================================================================
console.log("\nThird Task");

function ShowInfo({
  state: {
    profilePage: {
      posts,
    },
    dialogsPage: {
      dialogs,
      messages,
    }
  }
}) {
  console.log("linkesCount: ");
  for (let element of posts)
    console.log(element.linkesCount);

  console.log("\nЧетное ID: ");
  let filter = dialogs.filter(peoeple => peoeple.id % 2 === 0);
  for (let element of filter)
    console.log(element);

  console.log("\nЗамена на HELLO user: ");
  for (let element of messages)
    element.message = "HELLO user"
  for (let element of messages)
    console.log(element);
}


let store = {
  state: { //уровень 1
    profilePage: {  //уровень 2
      posts: [    //уровень 3
        { id: 1, message: 'Hi', linkesCount: 12 },
        { id: 2, message: 'By', linkesCount: 1 },
      ],
      newPostText: 'About me',
    },
    dialogsPage: {
      dialogs: [
        { id: 1, name: 'Valera' },
        { id: 2, name: 'Andrey' },
        { id: 3, name: 'Sasha' },
        { id: 4, name: 'Viktor' },
      ],
      messages: [
        { id: 1, message: 'Hi' },
        { id: 2, message: 'Hi Hi' },
        { id: 3, message: 'Hi Hi Hi' },
      ],
    },
    sidebar: [],
  }
}

ShowInfo(store);

//4.=================================================================
console.log("\nFourth Task");

let tasks = [
  { id: 1, title: "HTML&CSS", isDone: true },
  { id: 2, title: "JS", isDone: true },
  { id: 3, title: "ReactJS", isDone: false },
  { id: 4, title: "Rest  API", isDone: false },
  { id: 5, title: "GraphQL", isDone: false },
];

let newTask = { id: 6, title: "newTask", isDone: false };

tasks = [...tasks, newTask];
for (let task of tasks) {
  console.log(task);
}

//5.=================================================================
console.log("\nFifth Task");

function sumValues(x, y, z) {
  return x + y + z;
}

let arr = [1, 2, 3];

console.log(sumValues(...arr));