let date = 201223 ;

let year = date % 100;
let month = Math.floor((date % 10000) / 100); 
let day = Math.floor(date /10000);

function swap(el1, el2)
{
  let temp = daysDate[el1];
  daysDate[el1] = daysDate[el2];
  daysDate[el2] = temp;
}


const daysDate = [
  120123,
  141224,
  200524,
  250623,
  240723,
  220724,
  201223,
];

for(let i = 0; i < daysDate.length; i++ )
{
  console.log(daysDate[i])
}

// if(daysDate[0] % 100 < daysDate[1] % 100)
//       {
//         swap(0, 1)
//       }  

function checkDay(daysDate)
{
  for(let i = 0; i < daysDate.length; i++)
  {
    for(let j = 0; j < daysDate.length; j++)
    {
      if(daysDate[i] % 100 < daysDate[j] % 100)
      {
        swap(i, j)
      }    
    }
  }
}

function checkDay1(daysDate)
{
  for(let i = 0; i < daysDate.length; i++)
  {
    for(let j = 0; j < daysDate.length; j++)
    {
      if( Math.floor((daysDate[i] % 10000)  / 100) < Math.floor(((daysDate[j] % 10000) / 100)))
      {
        swap(i, j)
      }    
    }
  }
}

function checkDay2(daysDate)
{
  for(let i = 0; i < daysDate.length; i++)
  {
    for(let j = 0; j < daysDate.length; j++)
    {
      if( Math.floor(daysDate[i] /10000) < Math.floor(daysDate[j] /10000))
      {
        swap(i, j)
      }    
    }
  }
}

checkDay(daysDate);
checkDay1(daysDate);
checkDay2(daysDate);

console.log("///////////////////////////////////////////////////");

for(let i = 0; i < daysDate.length; i++ )
{
  console.log(daysDate[i])
}