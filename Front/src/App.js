import React, { useState, useEffect } from 'react';
import Login from './pages/Login';
// import { Data } from './types/data';
import './styles/App.css';
import PostService from './API/PostService';
import GetPostItems from './API/GetPostItems';
import HeaderDiv from './components/HeaderDiv';
import PostItem from './components/PostItem';
import TextBlock from './components/TextBlock';
import TextItem from './components/TextItem';
import MyFooter from './components/MyFooter';



function App() {


  const [data, setData] = useState([]);

  useEffect(() => {
    async function fetchGet() {
      const posts = await PostService.getall();
      setData(posts);
    }

    fetchGet();
  }, []);
  const [postitem, setPostItem] = useState([]);

  useEffect(() => {
    async function fetchGetItems() {
      const posts1 = await GetPostItems.getall();
      setPostItem(posts1);
    }

    fetchGetItems();
}, []);


  return (
   
    <div className="App">
    
       <HeaderDiv/>  

       <div className="ConteinerPostItem">{
    
      postitem?.map(post =>
          <PostItem key={post.id} post={post} />)}
       </div>
      {data ? <TextBlock block={data} /> : <></>}
      <MyFooter></MyFooter>

    </div>
    
  );
}

export default App;


