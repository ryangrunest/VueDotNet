import axios from "axios";

const apiEnv = "https://localhost:5001";

const api = {
  getAllFavoriteFoods: () => {
    return new Promise((resolve, reject) => {
      try {
        const config = {
          method: "GET",
          url: `${apiEnv}/api/FoodApi`,
        };
        axios(config).then((response) => {
          console.log(response);
          resolve(response?.data);
        });
      } catch (err) {
        console.warn("error while connecting to db", err);
        reject(false);
      }
    });
  },
  deleteFood: (food) => {
    return new Promise((resolve, reject) => {
      console.log("deleting food");
      try {
        const config = {
          method: "DELETE",
          url: `${apiEnv}/api/FoodApi/${food.id}`,
        };
        axios(config).then((response) => {
          console.log(response);
          resolve(response);
        });
      } catch (err) {
        console.warn("error while deleting food", food, err);
        reject(false);
      }
    });
  },
};

export default api;
