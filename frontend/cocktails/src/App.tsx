import "./App.css";
import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import { WelcomePage } from "./components/WelcomePage/WelcomePage";
import { HomePage } from "./components/HomePage/HomePage";
import { CocktailSearch } from "./components/CocktailSearch/CocktailSearch";

function App() {
  return (
    <div className="App">
      <Router>
        <Routes>
          <Route path="/" element={<WelcomePage />} />
          <Route path="/home" element={<HomePage />} />
          <Route path="/cocktail-search" element={<CocktailSearch />} />
        </Routes>
      </Router>
    </div>
  );
}

export default App;
