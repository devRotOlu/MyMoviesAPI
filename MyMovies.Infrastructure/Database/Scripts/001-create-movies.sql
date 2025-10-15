CREATE TABLE IF NOT EXISTS movies (
  id SERIAL PRIMARY KEY,
  title VARCHAR(100) NOT NULL,
  description TEXT NOT NULL,
  genre VARCHAR(100) NOT NULL,
  director VARCHAR(100) NOT NULL,
  thumbnail_url TEXT NOT NULL,
  video_path TEXT NOT NULL,
  release_date TIMESTAMP,
  duration_minutes INT,
  added_at TIMESTAMP NOT NULL
);