import "./HomePage.scss";
import { Link } from "react-router-dom";

export const HomePage: React.FunctionComponent = () => {
  return (
    <div>
      <img src="browsecocktails.JPG" className="home-link"></img>
      <Link to="/cocktail-search">
        <img src="searchbyingredient.JPG" className="home-link"></img>
      </Link>
    </div>
  );
};
