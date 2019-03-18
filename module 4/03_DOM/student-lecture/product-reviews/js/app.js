const g_name = 'Cigar Parties for Dummies';
const g_description = 'Host and plan the perfect cigar party for all of your squirrelly friends.';
const g_reviews = [
  {
    reviewer: 'Malcolm Gladwell',
    title: 'What a book!',
    review:
      "It certainly is a book. I mean, I can see that. Pages kept together with glue (I hope that's glue) and there's writing on it, in some language.",
    rating: 3
  },
  {
    reviewer: 'Tim Ferriss',
    title: 'Had a cigar party started in less than 4 hours.',
    review:
      "It should have been called the four hour cigar party. That's amazing. I have a new idea for muse because of this.",
    rating: 4
  },
  {
    reviewer: 'Ramit Sethi',
    title: 'What every new entrepreneurs needs. A door stop.',
    review:
      "When I sell my courses, I'm always telling people that if a book costs less than $20, they should just buy it. If they only learn one thing from it, it was worth it. Wish I learned something from this book.",
    rating: 1
  },
  {
    reviewer: 'Gary Vaynerchuk',
    title: 'And I thought I could write',
    review:
      "There are a lot of good, solid tips in this book. I don't want to ruin it, but prelighting all the cigars is worth the price of admission alone.",
    rating: 3
  }
];

/**
 * Add our product name to the page title
 * Get our page page title by the id and the query the .name selector
 * once you have the element you can add the product name to the span.
 */
function setPageTitle() {
  const pageTitle = document.getElementById('page-title');
  pageTitle.querySelector('.name').innerText = g_name;
}

/**
 * Add our product description to the page.
 */
function setPageDescription() {
  document.querySelector('.description').innerText = g_description;
}

/**
 * I will display all of the reviews on the page.
 * I will loop over the array of reviews and use some helper functions
 * to create the elements needed for our markup and add them to the DOM
 */
function displayReviews() {
  const mainNode = document.getElementById('main');

  for(let i = 0; i < g_reviews.length; i++) {
    const reviewNode = createReviewNode(i);
    mainNode.insertAdjacentElement('beforeend', reviewNode);
  }
}

function createReviewNode(reviewIndex) {
  const reviewData = g_reviews[reviewIndex];

  const reviewNode = document.createElement('div');
  reviewNode.setAttribute('class','review');

  const reviewerNode = document.createElement('h4');
  reviewerNode.innerText = reviewData.reviewer;
  reviewNode.insertAdjacentElement('beforeend', reviewerNode);

  const ratingNode = createRatingNode(reviewData.rating);
  reviewNode.insertAdjacentElement('beforeend', ratingNode);

  const titleNode = document.createElement('h3');
  titleNode.innerText = reviewData.title;
  reviewNode.insertAdjacentElement('beforeend', titleNode);

  const reviewTextNode = document.createElement('p');
  reviewTextNode.innerText = reviewData.review;
  reviewNode.insertAdjacentElement('beforeend', reviewTextNode);

  return reviewNode;
}

function createRatingNode(starRating) {
  const ratingNode = document.createElement('div');
  ratingNode.setAttribute('class','rating');
  for(let i = 0; i < starRating; i++) {
    const starNode = document.createElement('img');
    starNode.setAttribute('class','ratingStar'); 
    starNode.setAttribute('src','img/star.png'); 
    ratingNode.insertAdjacentElement('beforeend', starNode);
  }
  return ratingNode;
}

// set the product reviews page title
setPageTitle();
// set the product reviews page description
setPageDescription();
// display all of the product reviews on our page
displayReviews();
