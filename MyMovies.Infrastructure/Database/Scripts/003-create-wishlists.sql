CREATE TABLE IF NOT EXISTS wishlists (
  user_id INT,
  movie_id INT,
  added_at TIMESTAMP NOT NULL,
  CONSTRAINT pk_watchlist PRIMARY KEY (user_id, movie_id),
  CONSTRAINT fk_wishlist_user FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE,
  CONSTRAINT fk_wishlist_movie FOREIGN KEY (movie_id) REFERENCES movies(id) ON DELETE CASCADE
);