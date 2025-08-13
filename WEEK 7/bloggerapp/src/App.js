import React from 'react';
import './App.css';
import CourseDetails from './components/CourseDetails';
import BookDetails from './components/BookDetails';
import BlogDetails from './components/BlogDetails';

function App() {
  const courses = [
    { id: 1, name: 'Angular', date: '4/5/2021' },
    { id: 2, name: 'React', date: '6/3/2021' }
  ];

  const books = [
    { id: 101, title: 'Master React', price: 670 },
    { id: 102, title: 'Deep Dive into Angular 11', price: 800 },
    { id: 103, title: 'Mongo Essentials', price: 450 }
  ];

  const blogs = [
    { id: 201, title: 'React Learning', author: 'Stephen Biz', content: 'Welcome to learning React!' },
    { id: 202, title: 'Installation', author: 'Schwedziner', content: 'You can install React from npm.' }
  ];

  return (
    <div className="container">
      <div className="column">
        <h2>Course Details</h2>
        {courses.map(course => (
          <CourseDetails key={course.id} name={course.name} date={course.date} />
        ))}
      </div>

      <div className="column">
        <h2>Book Details</h2>
        {books.map(book => (
          <BookDetails key={book.id} title={book.title} price={book.price} />
        ))}
      </div>

      <div className="column">
        <h2>Blog Details</h2>
        {blogs.map(blog => (
          <BlogDetails key={blog.id} title={blog.title} author={blog.author} content={blog.content} />
        ))}
      </div>
    </div>
  );
}

export default App;
