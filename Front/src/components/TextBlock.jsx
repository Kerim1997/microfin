import React, { useState } from "react";
import TextItem from './TextItem.jsx';
import '../styles/TextBlock.css';

<styles />



const TextBlock = (props) => {
  return (
    <div className="KontentTextBlock">
      {
        props.block.map(content =>
          <TextItem key={content.id} content={content} />)
      }

    </div>
  );
};
export default TextBlock;