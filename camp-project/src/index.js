import React from 'react';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import { BrowserRouter, Router } from 'react-router-dom';
import ReactDOM  from 'react-dom';

ReactDOM.render(<BrowserRouter><App /></BrowserRouter>,document.getElementById('root'));
//const root = createRoot(document.getElementById('root'));
//root.render(<App />);
// root.render(
//    <React.StrictMode>
//     <App />
//    </React.StrictMode>
//   );

// const rootElement = document.getElementById('root');
// const root = createRoot(rootElement);
// root.render(
//   <Router>
//     <App />
//   </Router>
// );

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();

