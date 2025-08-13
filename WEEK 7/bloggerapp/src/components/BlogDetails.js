import React from 'react';

function BlogDetails({ title, author, content }) {
  return (
    <div className="item">
      <p className="item-name">{title}</p>
      <p className="item-author">{author}</p>
      <p className="item-content">{content}</p>
    </div>
  );
}

export default BlogDetails;
