function loadReviews() {
    console.log("Load Reviews...");
  
    fetch('data.json') 
    .then((response) => {
      return response.json();
    })
    .then((data) => {
      reviews = data;
    })
    .catch((err) => console.error(err));
  }


//   fetch(ajaxURL, {
//     method: 'post', // *GET, POST, PUT, DELETE, etc.
//     mode: 'cors', // no-cors, cors, *same-origin
//     headers: {
//         "Content-Type": "application/json",
//         // "Content-Type": "application/x-www-form-urlencoded",
//     },
//     cache: "no-cache", // *default, no-cache, reload, force-cache, only-if-cached
//     credentials: "same-origin", // include, *same-origin, omit
//     redirect: "follow", // manual, *follow, error
//     referrer: "no-referrer", // no-referrer, *client
//     body: JSON.stringify(player),
// })
// .then(response => response.json())
// .then( (data) => {     // this is a bit of magic for now, just know that response is a Response object
//         console.log(data.message);  // this block is where we write code to handle the HTTP response, here we're just logging the response object
// })
// .catch(error => console.error('Error:', error));