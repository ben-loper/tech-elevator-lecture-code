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