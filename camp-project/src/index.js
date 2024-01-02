import React from "react";
import "./index.css";
import App from "./App";
import { BrowserRouter, Router } from "react-router-dom";
import ReactDOM from "react-dom";
import { Provider } from "react-redux";
import { configureStore } from "./store/configureStore";

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <Provider store={configureStore()}>
    <BrowserRouter>
      <App />
    </BrowserRouter>
  </Provider>
);
